import * as React from "react";
import * as d3 from "d3";
import { useEffect, useState, useRef, useLayoutEffect } from "react";

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

// Create a wrapper component to handle client-side only rendering
export const LineChart: React.FunctionComponent<LineChartProps> = (props) => {
  const [isMounted, setIsMounted] = useState(false);
  
  // Only render on client-side
  useEffect(() => {
    setIsMounted(true);
  }, []);
  
  // Show a placeholder during SSR
  if (!isMounted) {
    return (
      <div 
        className="line-chart-container" 
        style={{ 
          width: `${props.width}px`, 
          height: `${props.height}px`, 
          position: 'relative',
          borderRadius: '8px',
          boxShadow: '0 4px 6px rgba(0,0,0,0.05)',
          background: 'white',
          padding: '8px',
          display: 'flex',
          alignItems: 'center',
          justifyContent: 'center'
        }}
      >
        <div>Loading chart...</div>
      </div>
    );
  }
  
  // Render the actual chart component once mounted
  return <LineChartImpl {...props} />;
};

// Implementation component that only runs on client-side
const LineChartImpl: React.FunctionComponent<LineChartProps> = ({
  data,
  width,
  height,
}) => {
  const svgRef = useRef<SVGSVGElement>(null);
  const containerRef = useRef<HTMLDivElement>(null);
  const [renderKey, setRenderKey] = useState(0);
  const [chartRendered, setChartRendered] = useState(false);
  const renderAttemptRef = useRef(0);

  // Force re-render after component mounts with multiple attempts
  useEffect(() => {
    // Initial render
    const timer1 = setTimeout(() => {
      renderAttemptRef.current += 1;
      setRenderKey(prev => prev + 1);
      console.log(`[LineChart] Render attempt ${renderAttemptRef.current}`);
    }, 50);

    // Second attempt
    const timer2 = setTimeout(() => {
      renderAttemptRef.current += 1;
      setRenderKey(prev => prev + 1);
      console.log(`[LineChart] Render attempt ${renderAttemptRef.current}`);
    }, 300);

    // Third attempt (if needed)
    const timer3 = setTimeout(() => {
      renderAttemptRef.current += 1;
      setRenderKey(prev => prev + 1);
      console.log(`[LineChart] Render attempt ${renderAttemptRef.current}`);
    }, 1000);

    return () => {
      clearTimeout(timer1);
      clearTimeout(timer2);
      clearTimeout(timer3);
    };
  }, []);

  // Main chart rendering effect using useLayoutEffect for synchronous rendering
  useLayoutEffect(() => {
    console.log(`[LineChart] Rendering attempt ${renderKey}`);
    console.log(`[LineChart] Data available:`, !!data, data?.length);
    console.log(`[LineChart] SVG ref available:`, !!svgRef.current);
    
    // Safety checks
    if (!data || !data[0]?.values?.length) {
      console.warn("[LineChart] No data available");
      return;
    }

    if (!svgRef.current) {
      console.error("[LineChart] SVG element not found");
      return;
    }

    try {
      // Process data to ensure dates are Date objects
      const processedData = data.map(line => ({
        name: line.name,
        values: line.values.map(d => ({
          date: typeof d.date === 'string' ? new Date(d.date) : d.date,
          price: d.price
        }))
      }));

      // Create a stable reference to the SVG element
      const svgElement = svgRef.current;
      
      // Select the SVG element
      const svg = d3.select(svgElement);
      
      // Clear existing content
      svg.selectAll("*").remove();
      
      // Add new container with more appropriate margins
      const margin = { top: 60, right: 30, bottom: 80, left: 60 };
      const chartWidth = width - margin.left - margin.right;
      const chartHeight = height - margin.top - margin.bottom;
      
      const g = svg
        .append("g")
        .attr("class", "chart-container")
        .attr("transform", `translate(${margin.left}, ${margin.top})`);
      
      // Set chart dimensions
      svg
        .attr("width", width)
        .attr("height", height)
        .attr("viewBox", `0 0 ${width} ${height}`)
        .style("font-family", "'Inter', 'Roboto', sans-serif");
      
      const duration = 250;

      // Professional color palette
      const colors = ["#0066cc", "#ff9933", "#00cc99", "#cc3366", "#6666ff"];

      // Line styling
      const lineOpacity = "0.85";
      const otherLinesOpacity = "0.45";
      const lineOpacityHover = "1";
      const otherLinesOpacityHover = "0.25";
      const lineStroke = "3";
      const otherLinesStroke = "2";
      const lineStrokeHover = "4";

      // Circle styling
      const circleOpacity = "0.85";
      const circleRadius = 5;
      const circleRadiusHover = 7;

      /* Scale */
      const [minX, maxX] = d3.extent(processedData[0].values, (d) => d.date);
      if (!minX || !maxX) {
        console.error("Invalid date range in data");
        return;
      }

      const xScale = d3
        .scaleTime()
        .domain([minX, maxX])
        .range([0, chartWidth]);

      const [minY, maxY] = d3.extent(processedData[0].values, (d) => d.price);
      if (minY === undefined || maxY === undefined) {
        console.error("Invalid price range in data");
        return;
      }

      const yScale = d3
        .scaleLinear()
        .domain([minY, maxY])
        .range([chartHeight, 0]);

      // Setup axes
      const xAxis = d3
        .axisBottom(xScale)
        .ticks(5)
        .tickFormat((d) => d3.timeFormat("%b %d, %Y")(d as Date));

      const yAxis = d3.axisLeft(yScale).ticks(5);

      // Add background for better visibility
      g.append("rect")
        .attr("width", chartWidth)
        .attr("height", chartHeight)
        .attr("fill", "#f9f9f9")
        .attr("opacity", 0.3)
        .attr("rx", 8)
        .attr("ry", 8);

      // Add chart title
      g.append("text")
        .attr("x", chartWidth / 2)
        .attr("y", -30)
        .attr("text-anchor", "middle")
        .attr("class", "chart-title")
        .style("font-size", "16px")
        .style("font-weight", "600")
        .style("fill", "#333")
        .text("Data Comparison by Region");

      // Add X axis with improved styling
      g.append("g")
        .attr("class", "x axis")
        .attr("transform", `translate(0, ${chartHeight})`)
        .call(xAxis)
        .selectAll("text")
        .style("text-anchor", "end")
        .style("font-size", "11px")
        .style("fill", "#666")
        .attr("dx", "-.8em")
        .attr("dy", ".15em")
        .attr("transform", "rotate(-45)");
        
      // Add X axis label
      g.append("text")
        .attr("class", "x-axis-label")
        .attr("x", chartWidth / 2)
        .attr("y", chartHeight + 60)
        .attr("text-anchor", "middle")
        .style("font-size", "12px")
        .style("fill", "#666")
        .text("Date");

      // Add Y axis with improved styling
      g.append("g")
        .attr("class", "y axis")
        .call(yAxis)
        .selectAll("text")
        .style("font-size", "11px")
        .style("fill", "#666");
        
      // Add Y axis label
      g.append("text")
        .attr("class", "y-axis-label")
        .attr("transform", "rotate(-90)")
        .attr("x", -chartHeight / 2)
        .attr("y", -40)
        .attr("text-anchor", "middle")
        .style("font-size", "12px")
        .style("fill", "#666")
        .text("Value");
        
      // Improve the appearance of grid lines
      g.selectAll(".axis line")
        .style("stroke", "#e0e0e0");
      g.selectAll(".axis path")
        .style("stroke", "#e0e0e0")
        .style("stroke-width", "1");
        
      // Add subtle grid lines
      g.append("g")
        .attr("class", "grid")
        .attr("transform", `translate(0, ${chartHeight})`)
        .call(d3.axisBottom(xScale)
          .tickSize(-chartHeight)
          .tickFormat(() => "")
        )
        .selectAll("line")
        .style("stroke", "#eaeaea")
        .style("stroke-dasharray", "3,3");

      /* Add line into SVG */
      const line = d3
        .line<Data>()
        .x((d) => xScale(d.date!))
        .y((d) => yScale(d.price))
        .defined((d) => d.date !== null);

      const lines = g.append("g").attr("class", "lines");

      lines
        .selectAll(".line-group")
        .data(processedData)
        .enter()
        .append("g")
        .attr("class", "line-group")
        .append("path")
        .attr("class", "line")
        .attr("stroke", (_d, i) => colors[i % colors.length])
        .attr("d", (d) => line(d.values))
        .style("fill", "none")
        .style("stroke-width", lineStroke)
        .style("opacity", lineOpacity)
        .on("mouseover", function (_event, d) {
          // Reduce opacity and stroke width of other lines
          lines
            .selectAll(".line")
            .transition()
            .duration(duration)
            .style("opacity", (otherD) =>
              otherD === d ? lineOpacityHover : otherLinesOpacityHover
            )
            .style("stroke-width", (otherD) =>
              otherD === d ? lineStrokeHover : otherLinesStroke
            );

          // Highlight the current line
          d3.select(this)
            .transition()
            .duration(duration)
            .style("opacity", lineOpacityHover)
            .style("stroke-width", lineStrokeHover);
        })
        .on("mouseout", function () {
          lines
            .selectAll(".line")
            .transition()
            .duration(duration)
            .style("opacity", lineOpacity)
            .style("stroke-width", lineStroke);
        });

      /* Add circles in the line */
      lines
        .selectAll("circle-group")
        .data(processedData)
        .enter()
        .append("g")
        .style("fill", (_d, i) => colors[i % colors.length])
        .selectAll("circle")
        .data((d) => d.values)
        .enter()
        .append("circle")
        .attr("class", "circle")
        .attr("cx", (d) => xScale(d.date!))
        .attr("cy", (d) => yScale(d.price))
        .attr("r", circleRadius)
        .style("opacity", circleOpacity)
        .on("mouseover", function (_event, d) {
          // Highlight circle
          d3.select(this)
            .transition()
            .duration(duration)
            .attr("r", circleRadiusHover);

          // Show tooltip
          g.append("text")
            .attr("class", "hover-text")
            .attr("x", xScale(d.date!) + 5)
            .attr("y", yScale(d.price) - 10)
            .text(`Value: ${d.price.toLocaleString()}`)
            .style("font-size", "12px")
            .style("font-weight", "500")
            .style("fill", "#333")
            .style("filter", "drop-shadow(0px 1px 1px rgba(0,0,0,0.1))");
        })
        .on("mouseout", function () {
          // Restore circle
          d3.select(this)
            .transition()
            .duration(duration)
            .attr("r", circleRadius);

          // Remove tooltip
          g.select(".hover-text").remove();
        });

      // Mark as rendered successfully
      setChartRendered(true);
      console.log("[LineChart] Chart rendered successfully");
    } catch (error) {
      console.error("Error rendering LineChart:", error);
    }
  }, [data, width, height, renderKey]);

  return (
    <div 
      ref={containerRef}
      className="line-chart-container" 
      style={{ 
        width: `${width}px`, 
        height: `${height}px`, 
        position: 'relative',
        borderRadius: '8px',
        boxShadow: '0 4px 6px rgba(0,0,0,0.05)',
        background: 'white',
        padding: '8px'
      }}
    >
      {!chartRendered && (
        <div style={{ 
          position: 'absolute', 
          top: '50%', 
          left: '50%', 
          transform: 'translate(-50%, -50%)',
          display: 'flex',
          alignItems: 'center',
          justifyContent: 'center',
          color: '#666',
          fontWeight: 500
        }}>
          <svg width="20" height="20" viewBox="0 0 24 24" style={{ 
            marginRight: '8px', 
            animation: 'spin 1s linear infinite'
          }}>
            <circle cx="12" cy="12" r="10" fill="none" stroke="#ccc" strokeWidth="3" />
            <path fill="none" stroke="#666" strokeWidth="3" d="M12 2a10 10 0 0 1 10 10" />
          </svg>
          Loading chart...
        </div>
      )}
      <svg
        ref={svgRef}
        className="line-chart-svg"
        style={{ width: '100%', height: '100%' }}
        data-render-key={renderKey}
      />
      <style>
        {`
          @keyframes spin {
            0% { transform: rotate(0deg); }
            100% { transform: rotate(360deg); }
          }
        `}
      </style>
    </div>
  );
};

export default LineChart;