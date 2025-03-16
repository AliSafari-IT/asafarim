import * as d3 from "d3";
import { useEffect, useRef, useState } from "react";
import D3ChartWrapper from "./D3ChartWrapper";
import {logger} from '@/utils/logger';

interface Data {
  date: Date | string | null;
  price: number;
}

interface Line {
  name: string;
  values: Data[];
}

interface LineChartProps {
  width: number;
  height: number;
  data: Line[];
}

// Main component that handles client-side rendering
export default function LineChart({ width, height, data }: LineChartProps) {
  return (
    <D3ChartWrapper chartName="LineChart" width={width} height={height}>
      <LineChartImpl width={width} height={height} data={data} />
    </D3ChartWrapper>
  );
}

// Implementation component that does the actual D3 rendering
function LineChartImpl({ width, height, data }: LineChartProps) {
  const svgRef = useRef<SVGSVGElement>(null);
  const [processedData, setProcessedData] = useState<Line[]>([]);

  // Process data when component mounts or data changes
  useEffect(() => {
    try {
      const parseDate = d3.timeParse("%Y-%m");

      // Process and validate the data
      const processedLines = data
        .map((line) => {
          const validValues = line.values
            .filter(
              (d) =>
                d && d.date !== null && d.date !== undefined && !isNaN(d.price)
            )
            .map((d) => ({
              date: typeof d.date === "string" ? parseDate(d.date) : d.date,
              price: d.price,
            }))
            .filter((d) => d.date !== null) as { date: Date; price: number }[];

          return {
            name: line.name,
            values: validValues,
          };
        })
        .filter((line) => line.values.length > 0);

      setProcessedData(processedLines);
      logger.log(
        `[LineChart] Processed ${processedLines.length} lines of data`
      );
    } catch (error) {
      logger.error("[LineChart] Error processing data:", error);
    }
  }, [data]);

  // Render the chart when processed data is available
  useEffect(() => {
    if (!svgRef.current || processedData.length === 0) return;

    try {
      logger.log("[LineChart] Rendering chart with processed data");

      // Clear previous rendering
      const svg = d3.select(svgRef.current);
      svg.selectAll("*").remove();

      // Set up margins and dimensions
      const margin = { top: 20, right: 80, bottom: 30, left: 50 };
      const innerWidth = width - margin.left - margin.right;
      const innerHeight = height - margin.top - margin.bottom;

      // Find min and max dates across all lines
      const allDates = processedData.flatMap(
        (line) =>
          line.values
            .filter((d) => d.date instanceof Date) // Only keep items with actual Date objects
            .map((d) => d.date as Date) // Tell TypeScript these are definitely Date objects
      );

      // Safely use d3.min and d3.max with proper typing
      const minDate =
        allDates.length > 0 ? d3.min<Date>(allDates) || new Date() : new Date();

      const maxDate =
        allDates.length > 0 ? d3.max<Date>(allDates) || new Date() : new Date();

      // Find min and max prices across all lines
      const allPrices = processedData.flatMap((line) =>
        line.values.map((d) => d.price)
      );
      const minPrice = d3.min(allPrices) || 0;
      const maxPrice = d3.max(allPrices) || 100;

      // Create scales
      const xScale = d3
        .scaleTime()
        .domain([minDate, maxDate])
        .range([0, innerWidth]);

      const yScale = d3
        .scaleLinear()
        .domain([minPrice, maxPrice])
        .range([innerHeight, 0]);

      // Create line generator
      const line = d3
        .line<{ date: Date; price: number }>()
        .x((d) => xScale(d.date))
        .y((d) => yScale(d.price))
        .curve(d3.curveBasis);

      // Create color scale
      const color = d3.scaleOrdinal(d3.schemeCategory10);

      // Create axes
      const xAxis = d3.axisBottom(xScale);
      const yAxis = d3.axisLeft(yScale);

      // Create chart group
      const g = svg
        .append("g")
        .attr("transform", `translate(${margin.left},${margin.top})`);

      // Add x-axis
      g.append("g")
        .attr("class", "x axis")
        .attr("transform", `translate(0,${innerHeight})`)
        .call(xAxis);

      // Add y-axis
      g.append("g")
        .attr("class", "y axis")
        .call(yAxis)
        .append("text")
        .attr("transform", "rotate(-90)")
        .attr("y", 6)
        .attr("dy", ".71em")
        .style("text-anchor", "end")
        .text("Price");

      // Add lines
      const lineGroups = g
        .selectAll(".line-group")
        .data(processedData)
        .enter()
        .append("g")
        .attr("class", "line-group");

      lineGroups
        .append("path")
        .attr("class", "line")
        .attr("d", (d) => {
          // Filter to only include values with valid Date objects
          const validValues = d.values
            .filter((item) => item.date instanceof Date)
            .map((item) => ({
              date: item.date as Date,
              price: item.price,
            }));
          return line(validValues);
        })
        .style("stroke", (_d, i) => color(i.toString()))
        .style("fill", "none")
        .style("stroke-width", 2);

      // Add line labels
      lineGroups
        .append("text")
        .datum((d) => {
          const lastValidValue = d.values
            .filter((item) => item.date instanceof Date)
            .pop();
          return {
            name: d.name,
            value: lastValidValue,
          };
        })
        .attr("transform", (d) => {
          if (!d.value || !(d.value.date instanceof Date)) return "";
          return `translate(${xScale(d.value.date as Date)},${yScale(
            d.value.price
          )})`;
        })
        .attr("x", 3)
        .attr("dy", ".35em")
        .style("font", "10px sans-serif")
        .text((d) => d.name);

      // Add hover effects
      const mouseG = g.append("g").attr("class", "mouse-over-effects");

      mouseG
        .append("path")
        .attr("class", "mouse-line")
        .style("stroke", "#666")
        .style("stroke-width", "1px")
        .style("opacity", "0");

      const mousePerLine = mouseG
        .selectAll(".mouse-per-line")
        .data(processedData)
        .enter()
        .append("g")
        .attr("class", "mouse-per-line");

      mousePerLine
        .append("circle")
        .attr("r", 5)
        .style("stroke", (d, i) => color(i.toString()))
        .style("fill", "none")
        .style("stroke-width", "1px")
        .style("opacity", "0");

      mousePerLine.append("text").attr("transform", "translate(10,3)");

      mouseG
        .append("rect")
        .attr("width", innerWidth)
        .attr("height", innerHeight)
        .attr("fill", "none")
        .attr("pointer-events", "all")
        .on("mouseout", () => {
          d3.select(".mouse-line").style("opacity", "0");
          d3.selectAll(".mouse-per-line circle").style("opacity", "0");
          d3.selectAll(".mouse-per-line text").style("opacity", "0");
        })
        .on("mouseover", () => {
          d3.select(".mouse-line").style("opacity", "1");
          d3.selectAll(".mouse-per-line circle").style("opacity", "1");
          d3.selectAll(".mouse-per-line text").style("opacity", "1");
        })
        .on("mousemove", function (event) {
          const mouse = d3.pointer(event, this);
          d3.select(".mouse-line").attr(
            "d",
            `M${mouse[0]},${innerHeight} ${mouse[0]},0`
          );

          d3.selectAll(".mouse-per-line").attr(
            "transform",
            function (this: any, d: any) {
              // Type guard to ensure d has the expected structure
              if (!d || !d.values || !d.values.length) return "";

              const xDate = xScale.invert(mouse[0]);
              const bisect = d3.bisector(
                (d: { date: Date; price: number }) => d.date
              ).left;

              // Filter to only include values with valid Date objects
              const validValues = d.values
                .filter((item: any) => item.date instanceof Date)
                .map((item: any) => ({
                  date: item.date as Date,
                  price: item.price,
                }));

              if (!validValues.length) return "";

              const idx = bisect(validValues, xDate);

              if (idx >= validValues.length) return "";

              const x = xScale(validValues[idx].date);
              const y = yScale(validValues[idx].price);

              d3.select(this)
                .select("text")
                .text(`${d.name}: ${validValues[idx].price}`);

              return `translate(${x},${y})`;
            }
          );
        });

      logger.log("[LineChart] Chart rendered successfully");
    } catch (error) {
      logger.error("[LineChart] Error rendering chart:", error);
    }
  }, [processedData, width, height]);

  return (
    <svg
      ref={svgRef}
      width={width}
      height={height}
      style={{
        backgroundColor: "#fff",
        borderRadius: "8px",
        boxShadow: "0 4px 6px rgba(0,0,0,0.1)",
      }}
    />
  );
}
