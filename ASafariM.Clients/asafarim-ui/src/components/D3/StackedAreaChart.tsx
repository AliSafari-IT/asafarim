import React from "react";
import StackedChart from "@/components/D3/StackedChart";

interface DataRow {
  date: string | Date; // Accepts both formats
  [key: string]: number | string | Date | unknown; 
}

interface StackedAreaChartProps {
  data: DataRow[];
  width: number;
  height: number;
}

const StackedAreaChart: React.FC<StackedAreaChartProps> = ({ data: rawData, width, height }) => {
  const transformData = (rawData: any) => {
    return rawData.map((d: DataRow) => ({
        date: new Date(d.date), // Ensure date conversion
        apple: isNaN(Number(d.apples)) ? 0 : Number(d.apples), // Convert to number and prevent NaN
        orange: isNaN(Number(d.oranges)) ? 0 : Number(d.oranges),
        banana: isNaN(Number(d.bananas)) ? 0 : Number(d.bananas)
    }));
};


  return <StackedChart
    data={transformData(rawData)}
    width={width}
    height={height}
    type="area"
    xKey="date"
    yKeys={['apple', 'orange', 'banana']}
    dateFormat="%Y-%m-%d" 
  />;
};

export default StackedAreaChart;
