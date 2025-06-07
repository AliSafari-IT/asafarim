// E:\asm-fs\apps\frontends\asafarim-client\src\components\D3\StackedLineChart.tsx

import StackedChart from "@/components/D3/StackedChart";

interface StackedLineDataPoint {
    label: string;
    value: number;
    x: number;
    y: number;
}

interface StackedLineChartProps {
    data: StackedLineDataPoint[];
    width: number;
    height: number;
}

const StackedLineChart = ({ data, width, height }: StackedLineChartProps) => {
    const transformData = (rawData: any) => {
        // This is just an example, adjust according to your actual data structure
        return rawData.map((d: StackedLineDataPoint) => ({
            label: d.label,
            value: d.value,
            x: d.x,
            y: d.y
        }));
    };

    return <StackedChart
        data={transformData(data)}
        width={width}
        height={height}
        type="line"
        xKey="label"
        yKeys={['x', 'y']}  
        dateFormat="%Y-%m-%d"
        chartTitle="Stacked Line Chart"
    />;
};

export default StackedLineChart;

