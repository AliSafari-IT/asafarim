import * as React from "react";
import * as d3 from "d3";

interface Data {
  date: Date | null;
  price: number;
}

interface Line {
  name: string;
  values: Data[];
}

interface LineChartProps {
  data: Line[];
  width: number;
  height: number;
}

export const LineChart: React.FunctionComponent<LineChartProps> = ({ data, width, height }) => {
  const svgRef = React.useRef<SVGSVGElement>(null);

  React.useEffect(() => {
    if (!data || !data[0]?.values?.length) {
      console.warn('No data available for LineChart');
      return;
    }

    // Clear any existing SVG content
    const svgElement = svgRef.current;
    if (!svgElement) return;
    
    while (svgElement.firstChild) {
      svgElement.removeChild(svgElement.firstChild);
    }

    const svg = d3.select(svgElement);
    const margin = 50;
    const duration = 250;

    const lineOpacity = "1";
    const otherLinesOpacity = "0.3";
    const lineOpacityHover = "0.85";
    const otherLinesOpacityHover = "0.1";
    const lineStroke = "3.5";
    const otherLinesStroke = "1.5";
    const lineStrokeHover = "5";

    const circleOpacity = "0.85";
    const circleOpacityOnLineHover = "0.85";
    const circleRadius = 5;
    const circleRadiusHover = 6;

    try {
      /* Scale */
      const [minX, maxX] = d3.extent(data[0].values, (d) => d.date);
      if (!minX || !maxX) {
        console.error('Invalid date range in data');
        return;
      }

      const xScale = d3
        .scaleTime()
        .domain([minX, maxX])
        .range([0, width - margin]);

      const [minY, maxY] = d3.extent(data[0].values, (d) => d.price);
      if (minY === undefined || maxY === undefined) {
        console.error('Invalid price range in data');
        return;
      }

      const yScale = d3
        .scaleLinear()
        .domain([minY, maxY])
        .range([height - margin, 0]);

      /* Add SVG */
      const g = svg
        .attr("width", width + margin + "px")
        .attr("height", height + margin + "px")
        .append("g")
        .attr("transform", `translate(${margin}, ${margin})`);

      // Add background rect for better visibility
      g.append("rect")
        .attr("width", width - margin)
        .attr("height", height - margin)
        .attr("fill", "none");

      const xAxis = d3
        .axisBottom(xScale)
        .tickSize(height - margin)
        .tickSizeOuter(0)
        .tickFormat(d => d3.timeFormat("%Y-%m-%d")(d as Date))
        .tickPadding(15);

      const yAxis = d3
        .axisLeft(yScale)
        .tickSize(margin - width)
        .tickSizeOuter(0)
        .ticks(12)
        .tickPadding(20);

      // Add the X Axis
      g.append("g")
        .attr("class", "x axis")
        .attr("font-weight", "100")
        .attr("font-family", '"Roboto", "sans-serif"')
        .call(xAxis);

      // Add the Y Axis
      g.append("g")
        .attr("class", "y axis")
        .attr("font-weight", "100")
        .attr("font-family", '"Roboto", "sans-serif"')
        .call(yAxis)
        .append("text")
        .attr("y", 15)
        .attr("transform", "rotate(-90)");

      /* Add line into SVG */
      const line = d3
        .line<Data>()
        .x(d => xScale(d.date!))
        .y(d => yScale(d.price))
        .defined(d => d.date !== null); // Skip null dates

      const lines = g.append("g").attr("class", "lines");

      lines
        .selectAll(".line-group")
        .data(data)
        .enter()
        .append("g")
        .attr("class", "line-group")
        .append("path")
        .attr("class", "line")
        .attr("stroke", (_d, i) => d3.schemeCategory10[i])
        .attr("d", d => line(d.values))
        .style("fill", "none")
        .style("stroke-width", lineStroke)
        .style("opacity", lineOpacity)
        .style("stroke-opacity", otherLinesOpacity)
        .on("mouseover", function(_event, d) {
          // Reduce opacity and stroke width of other lines
          lines.selectAll(".line")
            .transition()
            .duration(duration)
            .style("opacity", (otherD) => otherD === d ? lineOpacityHover : otherLinesOpacityHover)
            .style("stroke-width", (otherD) => otherD === d ? lineStrokeHover : otherLinesStroke);
          
          // Highlight the current line
          d3.select(this)
            .transition()
            .duration(duration)
            .style("opacity", lineOpacityHover)
            .style("stroke-width", lineStrokeHover);
        })
        .on("mouseout", function() {
          lines.selectAll(".line")
            .transition()
            .duration(duration)
            .style("opacity", lineOpacity)
            .style("stroke-width", lineStroke);
        });

      /* Add circles in the line */
      lines
        .selectAll("circle-group")
        .data(data)
        .enter()
        .append("g")
        .style("fill", (_d, i) => d3.schemeCategory10[i])
        .selectAll("circle")
        .data(d => d.values)
        .enter()
        .append("circle")
        .attr("class", "circle")
        .attr("cx", d => xScale(d.date!))
        .attr("cy", d => yScale(d.price))
        .attr("r", circleRadius)
        .style("opacity", circleOpacity)
        .on("mouseover", function(_event, d) {
          // Highlight circle
          d3.select(this)
            .transition()
            .duration(duration)
            .attr("r", circleRadiusHover)
            .style("opacity", circleOpacityOnLineHover);

          // Add tooltip
          g.append("text")
            .attr("class", "hover-text")
            .attr("x", xScale(d.date!) + 10)
            .attr("y", yScale(d.price) - 10)
            .text(`${d.price}`)
            .style("font-size", "12px")
            .style("fill", "black");
        })
        .on("mouseout", function() {
          // Restore circle
          d3.select(this)
            .transition()
            .duration(duration)
            .attr("r", circleRadius)
            .style("opacity", circleOpacity);

          // Remove tooltip
          g.select(".hover-text").remove();
        });
    } catch (error) {
      console.error('Error rendering LineChart:', error);
    }

    // Cleanup function
    return () => {
      while (svgElement.firstChild) {
        svgElement.removeChild(svgElement.firstChild);
      }
    };
  }, [data, width, height]); // Re-render when these props change

  return (
    <svg 
      ref={svgRef} 
      className="w-full h-full rounded-lg shadow-sm"
      style={{ minHeight: '300px' }}
    />
  );
};

export default LineChart;