import StackedChart from "@/components/D3/StackedChart";
import React, {  } from "react";

interface StackedBarChartProps {
  data: any[];
  width: number;
  height: number;
}

const StackedBarChart: React.FC<StackedBarChartProps> = ({
  data,
  width = 700,
  height = 500,
}) => {
    return  <StackedChart
    data={data}
    width={width }
    height={height}
    type="bar"
    xKey="label"  
    yKeys={['value']} 
/>;
};



export default StackedBarChart;
