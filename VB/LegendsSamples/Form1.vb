Imports DevExpress.XtraCharts
Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports System.IO
Imports System.Windows.Forms

Namespace LegendsSamples
    Partial Public Class Form1
        Inherits Form


        Private financialSeries_Renamed As Series
        Private ReadOnly Property FinancialSeries() As Series
            Get
                If financialSeries_Renamed Is Nothing Then
                    financialSeries_Renamed = chart.GetSeriesByName("AUDUSD Daily")
                End If
                Return financialSeries_Renamed
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            InitializeChart()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' Get several required objects.
            Dim diagram As XYDiagram = TryCast(chart.Diagram, XYDiagram)
            If diagram Is Nothing Then
                Return
            End If
            Dim view As FinancialSeriesViewBase = TryCast(FinancialSeries.View, FinancialSeriesViewBase)
            If view Is Nothing Then
                Return
            End If
            Dim macd As Indicator = TryCast(view.Indicators.GetElementByName("MACD"), Indicator)

'            #Region "#AddAdditionalLegend"
            ' Create a new instance of Legend.
            Dim macdLegend As New Legend()
            chart.Legends.Add(macdLegend)
            ' Position it.
            macdLegend.DockTarget = diagram.Panes.GetPaneByName("macdPane")
            macdLegend.AlignmentHorizontal = LegendAlignmentHorizontal.Left
            macdLegend.AlignmentVertical = LegendAlignmentVertical.Top

            ' Assign the data displayed in legend.
            macd.Legend = macdLegend
'            #End Region ' #AddAdditionalLegend
        End Sub

        Private Sub InitializeChart()
            FinancialSeries.DataSource = LoadData()
            FinancialSeries.ArgumentDataMember = "Argument"
            FinancialSeries.ValueDataMembers.AddRange("LowValue", "HighValue", "OpenValue", "CloseValue")
        End Sub

        Private Function LoadData() As List(Of DataPoint)
            Dim result As New List(Of DataPoint)()
            Dim reader As New StreamReader("Data\AUDUSDDaily.csv")
            Do While Not reader.EndOfStream
                Dim line As String = reader.ReadLine()
                Dim values = line.Split(","c)
                Dim point = New DataPoint()
                point.Argument = Date.ParseExact(values(0), "yyyy.MM.dd", Nothing)
                point.OpenValue = Double.Parse(values(1), CultureInfo.InvariantCulture)
                point.HighValue = Double.Parse(values(2), CultureInfo.InvariantCulture)
                point.LowValue = Double.Parse(values(3), CultureInfo.InvariantCulture)
                point.CloseValue = Double.Parse(values(4), CultureInfo.InvariantCulture)
                result.Add(point)
            Loop
            Return result
        End Function

        Private Class DataPoint
            Public Property Argument() As Date
            Public Property LowValue() As Double
            Public Property HighValue() As Double
            Public Property OpenValue() As Double
            Public Property CloseValue() As Double
        End Class
    End Class
End Namespace
