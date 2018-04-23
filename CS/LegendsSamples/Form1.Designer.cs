namespace LegendsSamples {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.XYDiagramPane xyDiagramPane1 = new DevExpress.XtraCharts.XYDiagramPane();
            DevExpress.XtraCharts.SecondaryAxisY secondaryAxisY1 = new DevExpress.XtraCharts.SecondaryAxisY();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.StockSeriesView stockSeriesView1 = new DevExpress.XtraCharts.StockSeriesView();
            DevExpress.XtraCharts.MovingAverageConvergenceDivergence movingAverageConvergenceDivergence1 = new DevExpress.XtraCharts.MovingAverageConvergenceDivergence();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagramPane1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(secondaryAxisY1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(movingAverageConvergenceDivergence1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            xyDiagram1.AxisX.DateTimeScaleOptions.WorkdaysOnly = true;
            xyDiagram1.AxisX.GridLines.MinorVisible = true;
            xyDiagram1.AxisX.GridLines.Visible = true;
            xyDiagram1.AxisX.Interlaced = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1;0";
            xyDiagram1.AxisX.WholeRange.Auto = false;
            xyDiagram1.AxisX.WholeRange.MaxValueSerializable = "06/30/2015 00:00:00.000";
            xyDiagram1.AxisX.WholeRange.MinValueSerializable = "02/25/2015 00:00:00.000";
            xyDiagram1.AxisY.Interlaced = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = false;
            xyDiagramPane1.Name = "macdPane";
            xyDiagramPane1.PaneID = 0;
            xyDiagram1.Panes.AddRange(new DevExpress.XtraCharts.XYDiagramPane[] {
            xyDiagramPane1});
            secondaryAxisY1.Alignment = DevExpress.XtraCharts.AxisAlignment.Near;
            secondaryAxisY1.AxisID = 0;
            secondaryAxisY1.GridLines.Visible = true;
            secondaryAxisY1.Interlaced = true;
            secondaryAxisY1.Name = "Secondary AxisY 1";
            secondaryAxisY1.VisibleInPanesSerializable = "0";
            xyDiagram1.SecondaryAxesY.AddRange(new DevExpress.XtraCharts.SecondaryAxisY[] {
            secondaryAxisY1});
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left;
            this.chart.Legend.DockTargetName = "Default Pane";
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            series1.Name = "AUDUSD Daily";
            movingAverageConvergenceDivergence1.AxisYName = "Secondary AxisY 1";
            movingAverageConvergenceDivergence1.Name = "MACD";
            movingAverageConvergenceDivergence1.PaneName = "macdPane";
            movingAverageConvergenceDivergence1.ShowInLegend = true;
            stockSeriesView1.Indicators.AddRange(new DevExpress.XtraCharts.Indicator[] {
            movingAverageConvergenceDivergence1});
            series1.View = stockSeriesView1;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chart.Size = new System.Drawing.Size(1264, 681);
            this.chart.TabIndex = 0;
            chartTitle1.Text = "AUDUSD Daily";
            chartTitle1.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.chart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagramPane1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(secondaryAxisY1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(movingAverageConvergenceDivergence1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stockSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chart;
    }
}

