import React, { useEffect, useRef } from 'react';
import * as d3 from 'd3';
import { BaseType } from 'd3';
import d3cloud from "d3-cloud";
import './StackedChart.css';
import {logger} from '@/utils/logger';

interface DataPoint {
    [key: string]: any;
}

type ChartType = 'area' | 'line' | 'bar' | 'column' | 'scatter' | 'bubble' | 'pie' | 'donut' |
    'radar' | 'polar' | 'treemap' | 'heatmap' | 'heatmap3d' | 'wordcloud' | 'TimeSeries';

interface StackedChartProps {
    data: DataPoint[];
    width: number;
    height: number;
    margin?: { top: number; right: number; bottom: number; left: number };
    type: ChartType;
    xKey: string;
    yKeys: string[];
    chartTitle?: string;
    xLabel?: string;
    yLabel?: string;
    xLabelRotation?: number;
    yLabelRotation?: number;
    colors?: string[];
    dateFormat?: string;
}

const StackedChart: React.FC<StackedChartProps> = ({
    data,
    width,
    height,
    margin = { top: 20, right: 30, bottom: 50, left: 50 },
    type,
    xKey,
    yKeys,
    chartTitle,
    xLabel = "Date/Time",  // Default label
    yLabel = "Value",      // Default label
    xLabelRotation = 0,    // Default rotation for x-axis label
    yLabelRotation = 0,    // Default rotation for y-axis label
    colors = d3.schemeCategory10,
    dateFormat = "%Y-%m-%d", // Default format: "Jan 01, 2020"
}) => {
    const svgRef = useRef<SVGSVGElement>(null);

    useEffect(() => {
        if (!svgRef.current || data.length === 0) return;

        const svg = d3.select(svgRef.current);
        svg.selectAll('*').remove();


        if (type === "wordcloud") {
            // Type guard: Ensure data matches the expected word cloud structure
            if (Array.isArray(data) && data.every(d => "word" in d && "count" in d)) {
                renderWordCloud(svg, data as { word: string; count: number }[], width, height);
            } else {
                logger.error("Invalid data format for wordcloud", data);
            }
            return;
        }


        const innerWidth = width - margin.left - margin.right;
        const innerHeight = height - margin.top - margin.bottom;

        const formattedData = data.map(d => ({
            ...d,
            [xKey]: type === 'TimeSeries' ? new Date(d[xKey]) : d[xKey], // Ensure Date conversion for TimeSeries
            [yKeys[0]]: +d[yKeys[0]] || 0, // Convert to number explicitly
        }));

        logger.log("Processed Data in StackedChart:", formattedData);
        logger.log("Max Y Value:", d3.max(formattedData.map(d => d[yKeys[0]])));

        const xScale =
            (type === 'TimeSeries' || type === 'area' || type === 'scatter' || type === 'bubble')
                ? d3.scaleTime()
                    .range([0, innerWidth])
                    .domain(d3.extent(formattedData, d => new Date(d[xKey])) as [Date, Date])
                : d3.scaleBand()
                    .range([0, innerWidth])
                    .padding(0.1)
                    .domain(formattedData.map(d => String(d[xKey])));

        const yMax = d3.max(formattedData, d => d[yKeys[0]] !== undefined ? +d[yKeys[0]] : 1) || 1;

        const yScale = d3.scaleLinear()
            .domain([0, yMax])
            .range([innerHeight, 0]);

        let xAxis;
        if (type === 'TimeSeries') {
            xAxis = d3.axisBottom(xScale as d3.ScaleTime<number, number>)
                .tickFormat(d3.timeFormat(dateFormat) as any)
                .ticks(Math.max(5, innerWidth / 100)); // Adjust based on width
        } else {
            xAxis = d3.axisBottom(xScale as d3.ScaleBand<string>)
                .ticks(Math.max(5, innerWidth / 100)); // Adjust based on width
        }
        const yAxis = d3.axisLeft(yScale);

        // Create a group element to contain the chart
        const g = svg.append('g')
            .attr('transform', `translate(${margin.left},${margin.top})`);

        // Add chart title
        if (chartTitle) {
            svg.append('text')
                .attr('x', width / 2)
                .attr('y', margin.top / 2)
                .attr('text-anchor', 'middle')
                .attr('class', 'chart-title')
                .attr('y', margin.top / 1.4)
                .text(chartTitle);
        }

        // Add X-axis Label
        svg.append("text")
            .attr("x", margin.left + innerWidth / 2)
            .attr("y", height - 10)
            .attr("text-anchor", "middle")
            .style("font-size", "14px")
            .text(xLabel)
            .attr("transform", "rotate(" + xLabelRotation + ")");

        // Add Y-axis Label
        svg.append("text")
            .attr("transform", `rotate(-90)`)
            .attr("x", -height / 2)
            .attr("y", 15)
            .attr("text-anchor", "middle")
            .style("font-size", "14px")
            .text(yLabel);

        const colorScale = d3.scaleOrdinal(colors).domain(yKeys);

        if (type === 'TimeSeries') {
            renderTimeSeries(g, data, xScale as d3.ScaleTime<number, number>, yScale, colorScale, xKey, yKeys[0]);
        } else {
            const stack = d3.stack<any>().keys(yKeys);
            const stackedData = stack(data);
            // Validate stacked data
            stackedData.forEach(series => {
                series.forEach(point => {
                    if (isNaN(point[0]) || isNaN(point[1])) {
                        logger.error("Invalid stacked data point:", point);
                    }
                });
            });
            // Render based on chart type
            switch (type) {
                case 'area':
                    renderArea(g, stackedData, xScale, yScale, colorScale, xKey);
                    break;
                case 'line':
                    renderLine(g, stackedData, xScale, yScale, colorScale, xKey);
                    break;
                case 'bar':
                    renderBar(g, stackedData, xScale as d3.ScaleBand<string>, yScale, colorScale, xKey);
                    break;
                case 'column':
                    renderColumn(g, stackedData, xScale as d3.ScaleBand<string>, yScale, colorScale, xKey);
                    break;
            }
        }

        const xAxisGroup = g.append('g')
            .attr('transform', `translate(0,${innerHeight})`)
            .call(xAxis);

        // Rotate and reduce x-axis labels dynamically
        xAxisGroup.selectAll("text")
            .style("text-anchor", innerWidth < 600 ? "end" : "middle")
            .attr("dx", "-0.8em")
            .attr("dy", "0.15em")
            .attr("transform", innerWidth < 600 ? "rotate(-45)" : "rotate(0)");


        // Modify Y-axis rendering with yLabelRotation
        const yAxisGroup = g.append('g')
            .call(yAxis)
            .selectAll("text")
            .style("text-anchor", "middle")  // Centered text
            .attr("dx", "-0.5em")
            .attr("dy", "0.35em")
            .attr("transform", "rotate(" + yLabelRotation + ")");

        // Apply dynamic label adjustments
        adjustAxisLabels(xAxisGroup as unknown as d3.Selection<BaseType, unknown, SVGGElement, unknown>, type, width);
        adjustAxisLabels(yAxisGroup as unknown as d3.Selection<BaseType, unknown, SVGGElement, unknown>, type, width);
    }, [data, width, height, margin, type, xKey, yKeys, chartTitle, colors, xLabel, xLabelRotation, yLabel, yLabelRotation, dateFormat]);

    return <svg ref={svgRef} width={width} height={height} />;
};

function adjustAxisLabels(
    axisSelection: d3.Selection<BaseType, unknown, SVGGElement, unknown>,
    type: string,
    width: number
) {
    // Calculate rotation dynamically based on width
    let rotation = 0;
    let anchor = "middle";
    let dx = "0";
    let dy = "0.35em";

    if (type === "TimeSeries" || type === "StackedAreaChart") {
        rotation = width < 600 ? -45 : 0; // Rotate if chart width is small
        anchor = width < 600 ? "end" : "middle";
        dx = width < 600 ? "-0.8em" : "0";
        dy = width < 600 ? "0.15em" : "0.35em";
    } else if (type === "StackedBarChart" || type === "StackedColumnChart") {
        rotation = -45; // Always rotate for stacked bar/column
        anchor = "end";
        dx = "-0.5em";
        dy = "0.5em";
    } else if (type === "Scatterplot" || type === "LineChart") {
        rotation = width < 800 ? -30 : 0;
        anchor = width < 800 ? "end" : "middle";
        dx = width < 800 ? "-0.6em" : "0";
        dy = width < 800 ? "0.25em" : "0.35em";
    }

    // Apply transformations
    axisSelection
        .selectAll("text")
        .style("text-anchor", anchor)
        .attr("dx", dx)
        .attr("dy", dy)
        .attr("transform", `rotate(${rotation})`);
}


// Helper functions for rendering different chart types
function renderArea(
    g: d3.Selection<SVGGElement, unknown, null, undefined>,
    stackedData: d3.Series<any, string>[],
    xScale: d3.ScaleTime<number, number> | d3.ScaleBand<string>,
    yScale: d3.ScaleLinear<number, number>,
    colorScale: d3.ScaleOrdinal<string, string>,
    xKey: string

) {
    const area = d3.area<d3.SeriesPoint<any>>()
        .x(d => xScale(d.data[xKey] as any) as number)
        .y0(d => yScale(d[0]))
        .y1(d => yScale(d[1]));

    g.selectAll('path')
        .data(stackedData)
        .enter().append('path')
        .attr('d', area as any)
        .attr('fill', d => colorScale(d.key));
}

// Rendering Functions
function renderLine(
    g: d3.Selection<SVGGElement, unknown, null, undefined>,
    stackedData: d3.Series<any, string>[],
    xScale: d3.ScaleTime<number, number> | d3.ScaleBand<string>,
    yScale: d3.ScaleLinear<number, number>,
    colorScale: d3.ScaleOrdinal<string, string>,
    xKey: string
) {
    const line = d3.line<d3.SeriesPoint<any>>()
        .x(d => xScale(d.data[xKey] as any) || 0)
        .y(d => yScale(d[1]));

    g.selectAll('path')
        .data(stackedData)
        .enter().append('path')
        .attr('d', line as any)
        .attr('fill', 'none')
        .attr('stroke', d => colorScale(d.key))
        .attr('stroke-width', 2);
}

function renderBar(
    g: d3.Selection<SVGGElement, unknown, null, undefined>,
    stackedData: d3.Series<any, string>[],
    xScale: d3.ScaleBand<string>,
    yScale: d3.ScaleLinear<number, number>,
    colorScale: d3.ScaleOrdinal<string, string>,
    xKey: string
) {
    g.selectAll('g')
        .data(stackedData)
        .enter().append('g')
        .attr('fill', d => colorScale(d.key))
        .selectAll('rect')
        .data(d => d)
        .enter().append('rect')
        .attr('y', d => xScale(d.data[xKey] as string) as number)
        .attr('x', d => yScale(d[1]))
        .attr('height', xScale.bandwidth())
        .attr('width', d => Math.abs(yScale(d[0]) - yScale(d[1])))
        .attr('transform', _d => `translate(0, ${-xScale.bandwidth() / 1.05})`);
}

function renderColumn(
    g: d3.Selection<SVGGElement, unknown, null, undefined>,
    stackedData: d3.Series<any, string>[],
    xScale: d3.ScaleBand<string>,
    yScale: d3.ScaleLinear<number, number>,
    colorScale: d3.ScaleOrdinal<string, string>,
    xKey: string
) {
    g.selectAll('g')
        .data(stackedData)
        .enter().append('g')
        .attr('fill', d => colorScale(d.key))
        .selectAll('rect')
        .data(d => d)
        .enter().append('rect')
        .attr('x', d => xScale(d.data[xKey] as string) as number)
        .attr('y', d => yScale(d[1]))
        .attr('width', xScale.bandwidth())
        .attr('height', d => yScale(d[0]) - yScale(d[1]));
}

function renderTimeSeries(
    g: d3.Selection<SVGGElement, unknown, null, undefined>,
    data: DataPoint[],
    xScale: d3.ScaleTime<number, number>,
    yScale: d3.ScaleLinear<number, number>,
    colorScale: d3.ScaleOrdinal<string, string>,
    xKey: string,
    yKey: string
) {
    const line = d3.line<DataPoint>()
        .x(d => {
            const date = new Date(d[xKey] as string); // Convert explicitly
            if (isNaN(date.getTime())) {
                logger.error("Invalid Date Detected:", d[xKey]); // Debugging
                return 0; // Default to 0 if date is invalid
            }
            return xScale(date);
        })
        .y(d => {
            const yValue = parseFloat(d[yKey] as string) || 0;
            return yScale(yValue);
        })
        .curve(d3.curveMonotoneX);

    g.append('path')
        .datum(data)
        .attr('fill', 'none')
        .attr('stroke', colorScale(yKey))
        .attr('stroke-width', 2)
        .attr('d', line);
}

// Function to render a word cloud
function renderWordCloud(
    svg: d3.Selection<SVGSVGElement, unknown, null, undefined>,
    data: { word: string; count: number }[],
    width: number,
    height: number
) {
    const colorScale = d3.scaleOrdinal(d3.schemeCategory10); // Use D3 color scale

    const layout = d3cloud()
        .size([width, height])
        .words(
            data.map((d) => ({
                text: d.word,
                size: d.count, // Adjust the multiplier as needed
            }))
        )
        .padding(5)
        .rotate(() => (Math.random() < 0.5 ? 0 : 90))
        .font("Impact")
        .fontSize((d) => d.size?.valueOf() ?? 0)
        .on("end", draw);

    layout.start();

    function draw(words: { text: string; size: number; x?: number; y?: number; rotate?: number }[]) {
        svg
            .append("g")
            .attr("transform", `translate(${width / 2},${height / 2})`)
            .selectAll("text")
            .data(words)
            .enter()
            .append("text")
            .style("font-family", "Impact")
            .style("font-size", (d) => `${d.size}px`)
            .style("fill", (d) => colorScale(d.text)) // Assign color dynamically
            .attr("text-anchor", "middle")
            .attr("transform", (d) => `translate(${d.x},${d.y}) rotate(${d.rotate})`)
            .text((d) => d.text);
    }
}


export default StackedChart;