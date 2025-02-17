import { useRef, useEffect } from 'react';
import * as d3 from 'd3';
import { useTheme } from '@/contexts/ThemeContext';

// Define the type for the data prop
export interface TreeMapData {
    id: string;
    value: number;
    category: string;
    name: string;
}

// Define the structure for the hierarchy node
interface HierarchyData extends Partial<TreeMapData> {
    children?: TreeMapData[];
}

// Fix the issue with missing value properties by extending d3's HierarchyNode
type HierarchyNodeType = d3.HierarchyNode<TreeMapData> & {
    x0: number;
    y0: number;
    x1: number;
    y1: number;
};

function Treemap({ data, width, height }: { data: TreeMapData[]; width: number; height: number; }) {
    const svgRef = useRef<SVGSVGElement | null>(null);
    const legendRef = useRef<SVGSVGElement | null>(null);
    const theme = useTheme()?.theme || 'light';

    useEffect(() => {
        if (!data || data.length === 0) return;

        const svg = d3.select(svgRef.current);
        svg.selectAll('*').remove(); // Clear previous rendering

        const legendContainer = d3.select(legendRef.current);
        legendContainer.selectAll('*').remove(); // Clear legend

        svg.attr('width', width).attr('height', height);

        // Create hierarchy root node
        const root = d3.hierarchy<HierarchyData>({ children: data }) // Ensure correct type
            .sum(d => (d.value ?? 0)) // Avoid undefined value errors
            .sort((a, b) => (b.value ?? 0) - (a.value ?? 0));

        // Create treemap layout
        d3.treemap<HierarchyData>().size([width, height]).padding(2)(root);

        // Define color scale
        const fader = (color: string) => d3.interpolateRgb(color, '#fff')(0.3);
        const colorScale = d3.scaleOrdinal(d3.schemeCategory10.map(fader));

        // Append group elements for each node
        const nodes = svg.selectAll<SVGGElement, HierarchyNodeType>('g')
            .data(root.leaves() as unknown as HierarchyNodeType[])
            .join('g')
            .attr('transform', d => `translate(${d.x0},${d.y0})`);

        // Add rectangles for each node
        nodes.append('rect')
            .attr('width', d => d.x1 - d.x0)
            .attr('height', d => d.y1 - d.y0)
            .attr('fill', d => colorScale(d.data.category))
            .attr('stroke', '#fff');

        // Add text inside rectangles with auto-wrapping
        nodes.append('text')
            .attr('x', 5)
            .attr('y', 15)
            .attr('fill', theme === 'dark' ? '#fff' : '#000')
            .attr('font-size', '12px')
            .attr('font-weight', 'bold')
            .attr('text-anchor', 'start')
            .text(d => d.data.name.length > 10 ? `${d.data.name.slice(0, 10)}...` : d.data.name)
            .call(wrapText);

        // Function to wrap text inside rectangles
        function wrapText(selection: d3.Selection<SVGTextElement, HierarchyNodeType, SVGSVGElement | null, unknown>) {
            selection.each(function () {
                const node = d3.select(this);
    const parent = node.node()?.parentNode;
    const rectWidth = parent instanceof SVGGraphicsElement 
        ? parent.getBBox().width 
        : 0;
                const words = node.text().split(/\s+/).reverse();
                let line: string[] = [];
                let lineNumber = 0;
                const x = node.attr('x');
                const y = node.attr('y');
                let tspan = node.text('').append('tspan').attr('x', x).attr('y', y);

                while (words.length > 0) {
                    const word = words.pop();
                    if (word) line.push(word);
                    tspan.text(line.join(' '));
                    if ((tspan.node()?.getComputedTextLength() ?? 0) > rectWidth && line?.length > 1) {
                        line.pop();
                        tspan.text(line.join(' '));
                        line = word ? [word] : [];
                        tspan = node.append('tspan')
                            .attr('x', x)
                            .attr('y', y)
                            .attr('dy', `${++lineNumber * 12}px`)
                            .text(word || '');
                    }
                }
            });
        }

        // Extract unique categories for legend
        const categories = Array.from(new Set(data.map(d => d.category)));

        // Render legend
        const legend = legendContainer.selectAll('g')
            .data(categories)
            .join('g')
            .attr('transform', (_, i) => `translate(0, ${i * 25})`);

        legend.append('rect')
            .attr('width', 15)
            .attr('height', 15)
            .attr('fill', d => colorScale(d));

        legend.append('text')
            .attr('x', 25)
            .attr('y', 12)
            .attr('fill', theme === 'dark' ? '#fff' : '#000')
            .attr('font-size', '12px')
            .text(d => d);

    }, [data, theme, width, height]);

    return (
        <div>
            <svg ref={svgRef} width={width} height={height} />
            <svg ref={legendRef} width={width} height={height / 5} />
        </div>
    );
}

export function TreemapChart({ data, width = 700, height = 400 }: { data: TreeMapData[]; width?: number; height?: number; }) {
    return <Treemap data={data} width={width} height={height} />;
}

export default TreemapChart;
