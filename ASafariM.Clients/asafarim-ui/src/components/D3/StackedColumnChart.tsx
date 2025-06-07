// E:\asm-fs\apps\frontends\asafarim-client\src\components\D3\StackedColumnChart.tsx

import React, {  } from "react";
import StackedChart from "@/components/D3/StackedChart";

interface StackedColumnChartProps {
    data: any[];
    width: number;
    height: number;
}

const StackedColumnChart: React.FC<StackedColumnChartProps> = ({ data, width, height }) => {
    return  <StackedChart
    data={data}
    width={width }
    height={height}
    type="column"
    xKey="label"  
    yKeys={['value']} 
    dateFormat="%Y-%m-%d"
/>;
};

export default StackedColumnChart;