<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128572552/16.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T375201)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms Chart - Add an Additional Legend to a Chart

This example demonstrates how to add an additional legend to a chart control.

Create a new instance of the [Legend](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.Legend) class and add it to the legends collection. 
Configure the [Legend.DockTarget](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.Legend.DockTarget) property and specify the legend position with the `AlignmentHorizontal` and `AlignmentVertical` properties. 

Assign the created legend to the following properties to display it in the chart:

* [Indicator.Legend](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.Indicator.Legend)
* [SeriesBase.Legend](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.SeriesBase.Legend)
* [ConstantLine.Legend](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.ConstantLine.Legend)
* [Strip.Legend](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.Strip.Legend)

## Files to Review

* [Form1.cs](./CS/LegendsSamples/Form1.cs) (VB: [Form1.vb](./VB/LegendsSamples/Form1.vb))
  
## Documentation

* [Adding Legends](https://docs.devexpress.com/WindowsForms/115948/controls-and-libraries/chart-control/legends/adding-legends)



