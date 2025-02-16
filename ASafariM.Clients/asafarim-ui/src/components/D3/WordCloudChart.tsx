import React from "react";
import StackedChart from "./StackedChart";

interface WordCloudChartProps {
  data: { word: string; count: number }[];
  width: number;
  height: number;

}

const WordCloudChart: React.FC<WordCloudChartProps> = ({data, width, height}) => {
  return (
    <StackedChart
      type="wordcloud"
      data={data}
      width={width}
      height={height}
      xKey="word"
      yKeys={["count"]}
      />);
};

export default WordCloudChart;
