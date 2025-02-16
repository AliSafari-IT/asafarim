import { useEffect, useMemo, useRef, useState } from "react";
import { Tree } from "./data/treeMapData2";
import * as d3 from "d3";
import styles from "./d3.module.css";
import ChartContainer from "./ChartContainer";

type HierarchyProps = {
  width: number;
  height: number;
  data: Tree;
};

const colors = [
  "#e0ac2b",
  "#6689c6",
  "#a4c969",
  "#e85252",
  "#9a6fb0",
  "#a53253",
  "#7f7f7f",
];

export const Hierarchy = ({ width, height, data }: HierarchyProps) => {
  const [size, setSize] = useState({ width: 0, height: 0 });
  const containerRef = useRef<HTMLDivElement>(null);
  const chartRef = useRef<SVGSVGElement | null>(null);

  useEffect(() => {
    const updateSize = () => {
      if (containerRef.current) {
        setSize({
          width: containerRef.current.offsetWidth,
          height: containerRef.current.offsetHeight
        });
      }
    };

    window.addEventListener('resize', updateSize);
    updateSize();

    return () => window.removeEventListener('resize', updateSize);
  }, []);

  const hierarchy = useMemo(() => {
    return d3.hierarchy(data).sum((d) => d.value);
  }, [data]);

  // List of item of level 1 (just under root) & related color scale
  const firstLevelGroups = hierarchy?.children?.map((child) => child.data.name);
  const colorScale = d3
    .scaleOrdinal<string>()
    .domain(firstLevelGroups || [])
    .range(colors);

  const root = useMemo(() => {
    const treeGenerator = d3.treemap<Tree>()
      .size([size.width, size.height])
      .tile(d3.treemapBinary)
      .round(true)
      .padding(4);
    return treeGenerator(hierarchy);
  }, [hierarchy, size.width, size.height]);

  useEffect(() => {
    console.log("Data:", data);
    console.log("Size:", size);
    console.log("Root:", root);

    if (chartRef.current) {
      console.log("Rendering chart");
      // Clear any existing SVG content
      d3.select(chartRef.current).selectAll("*").remove();

      // Add the shapes to the SVG
      const svg = d3.select(chartRef.current);
      root.leaves().forEach((leaf) => {
        const parentName = leaf.parent?.data.name;
        const g = svg.append("g")
          .attr("class", styles.rectangle);

        g.append("rect")
          .attr("x", leaf.x0)
          .attr("y", leaf.y0)
          .attr("width", leaf.x1 - leaf.x0)
          .attr("height", leaf.y1 - leaf.y0)
          .attr("stroke", "transparent")
          .attr("fill", colorScale(`${parentName}`))
          .attr("class", styles.rectangle);

        g.append("text")
          .attr("x", leaf.x0 + 3)
          .attr("y", leaf.y0 + 3)
          .attr("font-size", 12)
          .attr("text-anchor", "start")
          .attr("alignment-baseline", "hanging")
          .attr("fill", "white")
          .attr("class", "font-bold")
          .text(leaf.data.name);

        g.append("text")
          .attr("x", leaf.x0 + 3)
          .attr("y", leaf.y0 + 18)
          .attr("font-size", 12)
          .attr("text-anchor", "start")
          .attr("alignment-baseline", "hanging")
          .attr("fill", "white")
          .attr("class", "font-light")
          .text(leaf.data.value);
      });
    } else {
      console.log("Chart ref is null");
    }
  }, [root, colorScale, data, size]);

  return (
    <ChartContainer
      containerRef={containerRef}
      style={{ width: `${width}px`, height: `${height}px` }}
    >
      <svg
        ref={chartRef}
        width={width}
        height={height}
        style={{ backgroundColor: '#f0f0f0' }}
      />
    </ChartContainer>
  );
};

export default Hierarchy;