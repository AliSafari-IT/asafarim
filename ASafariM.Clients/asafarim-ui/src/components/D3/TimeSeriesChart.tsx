import React from 'react';
import StackedChart from '@/components/D3/StackedChart';

interface TimeSeriesChartProps {
  data: { [key: string]: any }[];
  width: number;
  height: number;
  xKey: string;
  yKey: string;
}

const TimeSeriesChart: React.FC<TimeSeriesChartProps> = ({
  data,
  width,
  height,
  xKey,
  yKey,
}) => {

  return <StackedChart
    data={data}
    width={width}
    height={height}
    type="TimeSeries"
    xKey={xKey}
    yKeys={[yKey]}
    xLabel="Date"
    yLabel="Q³/s"
    dateFormat={"%Y-%m-%d"} // Pass custom format
    chartTitle='Monthly Average Discharge in Rhine River in m³/s'

  />;
};

export default TimeSeriesChart;
