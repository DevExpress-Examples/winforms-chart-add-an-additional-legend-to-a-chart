Imports DevExpress.XtraCharts
Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports System.IO
Imports System.Windows.Forms

Namespace LegendsSamples

    Public Partial Class Form1
        Inherits Form

        Private financialSeriesField As Series

        Private ReadOnly Property FinancialSeries As Series
            Get
                If financialSeriesField Is Nothing Then financialSeriesField = chart.GetSeriesByName("AUDUSD Daily")
                Return financialSeriesField
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            InitializeChart()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            ' Get several required objects.
            Dim diagram As XYDiagram = TryCast(chart.Diagram, XYDiagram)
            If diagram Is Nothing Then Return
            Dim view As FinancialSeriesViewBase = TryCast(FinancialSeries.View, FinancialSeriesViewBase)
            If view Is Nothing Then Return
            Dim macd As Indicator = TryCast(view.Indicators.GetElementByName("MACD"), Indicator)
#Region "#AddAdditionalLegend"
            ' Create a new instance of Legend.
            Dim macdLegend As Legend = New Legend()
            chart.Legends.Add(macdLegend)
            ' Position it.
            macdLegend.DockTarget = diagram.Panes.GetPaneByName("macdPane")
            macdLegend.AlignmentHorizontal = LegendAlignmentHorizontal.Left
            macdLegend.AlignmentVertical = LegendAlignmentVertical.Top
            ' Assign the data displayed in legend.
            macd.Legend = macdLegend
#End Region  ' #AddAdditionalLegend
        End Sub

        Private Sub InitializeChart()
            FinancialSeries.DataSource = LoadData()
            FinancialSeries.ArgumentDataMember = "Argument"
            FinancialSeries.ValueDataMembers.AddRange("LowValue", "HighValue", "OpenValue", "CloseValue")
        End Sub

        Private Function LoadData() As List(Of DataPoint)
            Dim result As List(Of DataPoint) = New List(Of DataPoint)()
            Dim reader As StreamReader = New StreamReader("Data\AUDUSDDaily.csv")
            While Not reader.EndOfStream
                Dim line As String = reader.ReadLine()
                Dim values = line.Split(","c)
                Dim point = New DataPoint()
                point.Argument = Date.ParseExact(values(0), "yyyy.MM.dd", Nothing)
                point.OpenValue = Double.Parse(values(1), CultureInfo.InvariantCulture)
                point.HighValue = Double.Parse(values(2), CultureInfo.InvariantCulture)
                point.LowValue = Double.Parse(values(3), CultureInfo.InvariantCulture)
                point.CloseValue = Double.Parse(values(4), CultureInfo.InvariantCulture)
                result.Add(point)
            End While

            Return result
        End Function

        Private Class DataPoint

            Public Property Argument As Date

            Public Property LowValue As Double

            Public Property HighValue As Double

            Public Property OpenValue As Double

            Public Property CloseValue As Double
        End Class
    End Class
End Namespace
