using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace LegendsSamples {
    public partial class Form1 : Form {
        Series financialSeries;
        Series FinancialSeries {
            get {
                if (financialSeries == null)
                    financialSeries = chart.GetSeriesByName("AUDUSD Daily");
                return financialSeries;
            }
        }

        public Form1() {
            InitializeComponent();
            InitializeChart();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Get several required objects.
            XYDiagram diagram = chart.Diagram as XYDiagram;
            if(diagram == null) return;
            FinancialSeriesViewBase view = FinancialSeries.View as FinancialSeriesViewBase;
            if(view == null) return;
            Indicator macd = view.Indicators.GetElementByName("MACD") as Indicator;

            #region #AddAdditionalLegend
            // Create a new instance of Legend.
            Legend macdLegend = new Legend();
            chart.Legends.Add(macdLegend);
            // Position it.
            macdLegend.DockTarget = diagram.Panes.GetPaneByName("macdPane");
            macdLegend.AlignmentHorizontal = LegendAlignmentHorizontal.Left;
            macdLegend.AlignmentVertical = LegendAlignmentVertical.Top;

            // Assign the data displayed in legend.
            macd.Legend = macdLegend;
            #endregion #AddAdditionalLegend
        }

        void InitializeChart() {
            FinancialSeries.DataSource = LoadData();
            FinancialSeries.ArgumentDataMember = "Argument";
            FinancialSeries.ValueDataMembers.AddRange("LowValue", "HighValue", "OpenValue", "CloseValue");
        }

        List<DataPoint> LoadData() {
            List<DataPoint> result = new List<DataPoint>();
            StreamReader reader = new StreamReader("Data\\AUDUSDDaily.csv");
            while(!reader.EndOfStream) {
                string line = reader.ReadLine();
                var values = line.Split(',');
                var point = new DataPoint();
                point.Argument = DateTime.ParseExact(values[0], "yyyy.MM.dd", null);
                point.OpenValue = double.Parse(values[1], CultureInfo.InvariantCulture);
                point.HighValue = double.Parse(values[2], CultureInfo.InvariantCulture);
                point.LowValue = double.Parse(values[3], CultureInfo.InvariantCulture);
                point.CloseValue = double.Parse(values[4], CultureInfo.InvariantCulture);
                result.Add(point);
            }
            return result;
        }

        class DataPoint {
            public DateTime Argument { get; set; }
            public double LowValue { get; set; }
            public double HighValue { get; set; }
            public double OpenValue { get; set; }
            public double CloseValue { get; set; }
        }
    }
}
