Namespace LegendsSamples
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
            Dim xyDiagramPane1 As New DevExpress.XtraCharts.XYDiagramPane()
            Dim secondaryAxisY1 As New DevExpress.XtraCharts.SecondaryAxisY()
            Dim series1 As New DevExpress.XtraCharts.Series()
            Dim stockSeriesView1 As New DevExpress.XtraCharts.StockSeriesView()
            Dim movingAverageConvergenceDivergence1 As New DevExpress.XtraCharts.MovingAverageConvergenceDivergence()
            Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
            Me.chart = New DevExpress.XtraCharts.ChartControl()
            DirectCast(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(xyDiagramPane1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(secondaryAxisY1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(stockSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(movingAverageConvergenceDivergence1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chart
            ' 
            xyDiagram1.AxisX.DateTimeScaleOptions.WorkdaysOnly = True
            xyDiagram1.AxisX.GridLines.MinorVisible = True
            xyDiagram1.AxisX.GridLines.Visible = True
            xyDiagram1.AxisX.Interlaced = True
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1;0"
            xyDiagram1.AxisX.WholeRange.Auto = False
            xyDiagram1.AxisX.WholeRange.MaxValueSerializable = "06/30/2015 00:00:00.000"
            xyDiagram1.AxisX.WholeRange.MinValueSerializable = "02/25/2015 00:00:00.000"
            xyDiagram1.AxisY.Interlaced = True
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
            xyDiagramPane1.Name = "macdPane"
            xyDiagramPane1.PaneID = 0
            xyDiagram1.Panes.AddRange(New DevExpress.XtraCharts.XYDiagramPane() { xyDiagramPane1})
            secondaryAxisY1.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
            secondaryAxisY1.AxisID = 0
            secondaryAxisY1.GridLines.Visible = True
            secondaryAxisY1.Interlaced = True
            secondaryAxisY1.Name = "Secondary AxisY 1"
            secondaryAxisY1.VisibleInPanesSerializable = "0"
            xyDiagram1.SecondaryAxesY.AddRange(New DevExpress.XtraCharts.SecondaryAxisY() { secondaryAxisY1})
            Me.chart.Diagram = xyDiagram1
            Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left
            Me.chart.Legend.DockTargetName = "Default Pane"
            Me.chart.Legend.Name = "Default Legend"
            Me.chart.Location = New System.Drawing.Point(0, 0)
            Me.chart.Name = "chart"
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            series1.Name = "AUDUSD Daily"
            movingAverageConvergenceDivergence1.AxisYName = "Secondary AxisY 1"
            movingAverageConvergenceDivergence1.Name = "MACD"
            movingAverageConvergenceDivergence1.PaneName = "macdPane"
            movingAverageConvergenceDivergence1.ShowInLegend = True
            stockSeriesView1.Indicators.AddRange(New DevExpress.XtraCharts.Indicator() { movingAverageConvergenceDivergence1})
            series1.View = stockSeriesView1
            Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
            Me.chart.Size = New System.Drawing.Size(1264, 681)
            Me.chart.TabIndex = 0
            chartTitle1.Text = "AUDUSD Daily"
            chartTitle1.Visibility = DevExpress.Utils.DefaultBoolean.False
            Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1264, 681)
            Me.Controls.Add(Me.chart)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(xyDiagramPane1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(secondaryAxisY1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(movingAverageConvergenceDivergence1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(stockSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private chart As DevExpress.XtraCharts.ChartControl
    End Class
End Namespace

