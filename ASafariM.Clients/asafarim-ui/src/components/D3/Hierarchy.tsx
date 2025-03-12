import { useEffect, useMemo, useRef, useState } from "react";
import { Tree } from "./data/treeMapData2";
import * as d3 from "d3";
import styles from "./d3.module.css";
import ChartContainer from "./ChartContainer";
import D3ChartWrapper from "./D3ChartWrapper";

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
  return (
    <D3ChartWrapper chartName="Hierarchy" width={width} height={height}>
      <HierarchyImpl width={width} height={height} data={data} />
    </D3ChartWrapper>
  );
};

// Implementation component that does the actual D3 rendering
const HierarchyImpl = ({ width, height, data }: HierarchyProps) => {
  const [size, setSize] = useState({ width, height });
  const containerRef = useRef<HTMLDivElement>(null);
  const chartRef = useRef<SVGSVGElement | null>(null);

  useEffect(() => {
    const updateSize = () => {
      if (containerRef.current) {
        setSize({
          width: containerRef.current.offsetWidth || width,
          height: containerRef.current.offsetHeight || height
        });
      }
    };

    window.addEventListener('resize', updateSize);
    updateSize();

    return () => window.removeEventListener('resize', updateSize);
  }, [width, height]);

  const hierarchy = useMemo(() => {
    try {
      return d3.hierarchy(data).sum((d) => d.value);
    } catch (error) {
      console.error("Error creating hierarchy:", error);
      return null;
    }
  }, [data]);

  // List of item of level 1 (just under root) & related color scale
  const firstLevelGroups = hierarchy?.children?.map((child) => child.data.name) || [];
  const colorScale = d3
    .scaleOrdinal<string>()
    .domain(firstLevelGroups)
    .range(colors);

  const root = useMemo(() => {
    if (!hierarchy) return null;
    
    try {
      const treeGenerator = d3.treemap<Tree>()
        .size([size.width, size.height])
        .tile(d3.treemapBinary)
        .round(true)
        .padding(4);
      return treeGenerator(hierarchy);
    } catch (error) {
      console.error("Error creating treemap:", error);
      return null;
    }
  }, [hierarchy, size.width, size.height]);

  useEffect(() => {
    if (!root) {
      console.warn("No root data available for Hierarchy chart");
      return;
    }

    if (!chartRef.current) {
      console.warn("Chart ref is null for Hierarchy chart");
      return;
    }

    try {
      console.log("Rendering Hierarchy chart");
      // Clear any existing SVG content
      d3.select(chartRef.current).selectAll("*").remove();

      // Add the shapes to the SVG
      const svg = d3.select(chartRef.current);
      
      // Ensure leaves() exists and has data
      const leaves = root.leaves();
      if (!leaves || leaves.length === 0) {
        console.warn("No leaf nodes found in hierarchy data");
        return;
      }
      
      leaves.forEach((leaf) => {
        if (!leaf || leaf.x0 === undefined || leaf.y0 === undefined) {
          console.warn("Invalid leaf node in hierarchy data", leaf);
          return;
        }
        
        const parentName = leaf.parent?.data.name || "";
        const g = svg.append("g")
          .attr("class", styles.rectangle);

        g.append("rect")
          .attr("x", leaf.x0)
          .attr("y", leaf.y0)
          .attr("width", Math.max(0, leaf.x1 - leaf.x0))
          .attr("height", Math.max(0, leaf.y1 - leaf.y0))
          .attr("stroke", "transparent")
          .attr("fill", colorScale(parentName))
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
    } catch (error) {
      console.error("Error rendering Hierarchy chart:", error);
    }
  }, [root, colorScale, size]);

  return (
    <ChartContainer
      containerRef={containerRef}
      style={{ width: `${width}px`, height: `${height}px` }}
    >
      <svg
        ref={chartRef}
        width={size.width}
        height={size.height}
        style={{ backgroundColor: '#f0f0f0' }}
      />
    </ChartContainer>
  );
};

export default Hierarchy;