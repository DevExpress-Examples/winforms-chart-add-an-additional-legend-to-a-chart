<!-- default file list -->
*Files to look at*:

* **[Form1.cs](./CS/LegendsSamples/Form1.cs) (VB: [Form1.vb](./VB/LegendsSamples/Form1.vb))**
<!-- default file list end -->
# How to: Add an additional legend to a chart


This example demonstrates how to add an additional legend to a chart control.


<h3>Description</h3>

<p>To do this, create a new instance of&nbsp;the <strong>Legend</strong>&nbsp;class and add it to the&nbsp;<strong>Chart.Legends</strong>&nbsp;collection.&nbsp;<br>Configure its&nbsp;<strong>DockTarget</strong>,&nbsp;<strong>AlignmentVertical</strong>&nbsp;and&nbsp;<strong>AlignmentHorizontal</strong>&nbsp;properties to position the legend at the required place.&nbsp;<br>Note that the legend will not be shown until it is assigned to the&nbsp;<strong>SeriesBase.Legend</strong>,&nbsp;<strong>Indicator.Legend</strong>,&nbsp;<strong>ConstantLine.Legend</strong>&nbsp;or&nbsp;<strong>Strip.Legend&nbsp;</strong>property.</p>

<br/>


