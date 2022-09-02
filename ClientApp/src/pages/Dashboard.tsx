import * as React from "react";
import { VerticalStackedBarChart } from "@fluentui/react-charting";
import { Separator, Stack } from "@fluentui/react";

import { ISepStyles, Theme } from "../styles/Theme";

// const firstChartPoints = [
//   {
//     legend: "Metadata1",
//     data: 40,
//     color: DefaultPalette.accent,
//     xAxisCalloutData: "2020/04/30",
//     yAxisCalloutData: "40%"
//   },
//   {
//     legend: "Metadata2",
//     data: 5,
//     color: DefaultPalette.blueMid,
//     xAxisCalloutData: "2020/04/30",
//     yAxisCalloutData: "5%"
//   },
//   {
//     legend: "Metadata3",
//     data: 20,
//     color: DefaultPalette.blueLight,
//     xAxisCalloutData: "2020/04/30",
//     yAxisCalloutData: "20%"
//   }
// ];

// const secondChartPoints = [
//   {
//     legend: "Metadata1",
//     data: 30,
//     color: DefaultPalette.accent,
//     xAxisCalloutData: "2020/04/30",
//     yAxisCalloutData: "30%"
//   },
//   {
//     legend: "Metadata2",
//     data: 20,
//     color: DefaultPalette.blueMid,
//     xAxisCalloutData: "2020/04/30",
//     yAxisCalloutData: "20%"
//   },
//   {
//     legend: "Metadata3",
//     data: 40,
//     color: DefaultPalette.blueLight,
//     xAxisCalloutData: "2020/04/30",
//     yAxisCalloutData: "40%"
//   }
// ];

// const thirdChartPoints = [
//   {
//     legend: "Metadata1",
//     data: 44,
//     color: DefaultPalette.accent,
//     xAxisCalloutData: "2020/04/30",
//     yAxisCalloutData: "44%"
//   },
//   {
//     legend: "Metadata2",
//     data: 28,
//     color: DefaultPalette.blueMid,
//     xAxisCalloutData: "2020/04/30",
//     yAxisCalloutData: "28%"
//   },
//   {
//     legend: "Metadata3",
//     data: 30,
//     color: DefaultPalette.blueLight,
//     xAxisCalloutData: "2020/04/30",
//     yAxisCalloutData: "30%"
//   }
// ];

// const fourthChartPoints = [
//   {
//     legend: "Metadata1",
//     data: 88,
//     color: DefaultPalette.accent,
//     xAxisCalloutData: "2020/04/30",
//     yAxisCalloutData: "88%"
//   },
//   {
//     legend: "Metadata2",
//     data: 22,
//     color: DefaultPalette.blueMid,
//     xAxisCalloutData: "2020/04/30",
//     yAxisCalloutData: "22%"
//   },
//   {
//     legend: "Metadata3",
//     data: 30,
//     color: DefaultPalette.blueLight,
//     xAxisCalloutData: "2020/04/30",
//     yAxisCalloutData: "30%"
//   }
// ];

// const data = [
//   { chartData: firstChartPoints, xAxisPoint: 0 },
//   { chartData: secondChartPoints, xAxisPoint: 20 },
//   { chartData: thirdChartPoints, xAxisPoint: 40 },
//   { chartData: firstChartPoints, xAxisPoint: 60 },
//   { chartData: fourthChartPoints, xAxisPoint: 80 },
//   { chartData: firstChartPoints, xAxisPoint: 100 }
// ];

// const Dashboard: React.FC = () => (
//   <VerticalStackedBarChart
//     aria-label="Vertical Stacked Bar Chart" // no prop to support this
//     data={data}
//     legendProps={{
//       overflowProps: {
//         focusZoneProps: {
//           "aria-label":
//             "Legends container. Use the container to highlight a specific device's color in the chart."
//         }
//       },
//       allowFocusOnLegends: true
//     }}
//   />
// );

// export default Dashboard;




export default function Dashboard() {
const firstChartPoints = [
  {
    legend: "Metadata1",
    data: 40,
    color: Theme.palette.themePrimary,
    xAxisCalloutData: "2020/04/30",
    yAxisCalloutData: "40%"
  },
  {
    legend: "Metadata2",
    data: 5,
    color: Theme.palette.neutralPrimary,
    xAxisCalloutData: "2020/04/30",
    yAxisCalloutData: "5%"
  },
  {
    legend: "Metadata3",
    data: 20,
    color: Theme.palette.neutralSecondaryAlt,
    xAxisCalloutData: "2020/04/30",
    yAxisCalloutData: "20%"
  }
];

const secondChartPoints = [
  {
    legend: "Metadata1",
    data: 30,
    color: Theme.palette.accent,
    xAxisCalloutData: "2020/04/30",
    yAxisCalloutData: "30%"
  },
  {
    legend: "Metadata2",
    data: 20,
    color: Theme.palette.blueMid,
    xAxisCalloutData: "2020/04/30",
    yAxisCalloutData: "20%"
  },
  {
    legend: "Metadata3",
    data: 40,
    color: Theme.palette.blueLight,
    xAxisCalloutData: "2020/04/30",
    yAxisCalloutData: "40%"
  }
];

const thirdChartPoints = [
  {
    legend: "Metadata1",
    data: 44,
    color: Theme.palette.accent,
    xAxisCalloutData: "2020/04/30",
    yAxisCalloutData: "44%"
  },
  {
    legend: "Metadata2",
    data: 28,
    color: Theme.palette.blueMid,
    xAxisCalloutData: "2020/04/30",
    yAxisCalloutData: "28%"
  },
  {
    legend: "Metadata3",
    data: 30,
    color: Theme.palette.blueLight,
    xAxisCalloutData: "2020/04/30",
    yAxisCalloutData: "30%"
  }
];

const fourthChartPoints = [
  {
    legend: "Metadata1",
    data: 88,
    color: Theme.palette.accent,
    xAxisCalloutData: "2020/04/30",
    yAxisCalloutData: "88%"
  },
  {
    legend: "Metadata2",
    data: 22,
    color: Theme.palette.themePrimary,
    xAxisCalloutData: "2020/04/30",
    yAxisCalloutData: "22%"
  },
  {
    legend: "Metadata3",
    data: 30,
    color: Theme.palette.themeSecondary,
    xAxisCalloutData: "2020/04/30",
    yAxisCalloutData: "30%"
  }
];

  const data = [
  { chartData: firstChartPoints, xAxisPoint: 0 },
  { chartData: secondChartPoints, xAxisPoint: 20 },
  { chartData: thirdChartPoints, xAxisPoint: 40 },
  { chartData: firstChartPoints, xAxisPoint: 60 },
  { chartData: fourthChartPoints, xAxisPoint: 80 },
  { chartData: firstChartPoints, xAxisPoint: 100 }
];
  return (
    <Stack
      horizontalAlign="center"
      tokens={{
        padding: "10px 0px 0px 0px",
        childrenGap: "3%",
        maxHeight: "100%",
        maxWidth: "100%",
      }}
    >
      <Separator theme={Theme} styles={ISepStyles}>
        Grafica de Latencia/Tiempo de Respuesta
      </Separator>

  <VerticalStackedBarChart
    aria-label="Vertical Stacked Bar Chart" // no prop to support this
    data={data}
    legendProps={{
      overflowProps: {
      },
      allowFocusOnLegends: true
    }}
  />
  </Stack>

  );
}