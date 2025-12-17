namespace FilmIzlemeUygulamasi
{
    partial class StatisticsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

      

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticsForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.chartCategoryCount = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartAverageRating = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnClose = new Bunifu.UI.WinForms.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategoryCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAverageRating)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(407, 23);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(499, 41);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "MOVIE STATISTICS AND REPORTS";
            // 
            // chartCategoryCount
            // 
            this.chartCategoryCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            chartArea1.Name = "ChartArea1";
            this.chartCategoryCount.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCategoryCount.Legends.Add(legend1);
            this.chartCategoryCount.Location = new System.Drawing.Point(84, 109);
            this.chartCategoryCount.Margin = new System.Windows.Forms.Padding(4);
            this.chartCategoryCount.Name = "chartCategoryCount";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Categories";
            this.chartCategoryCount.Series.Add(series1);
            this.chartCategoryCount.Size = new System.Drawing.Size(563, 469);
            this.chartCategoryCount.TabIndex = 1;
            title1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "Title1";
            title1.Text = "Category Distribution by Number of Films";
            this.chartCategoryCount.Titles.Add(title1);
            // 
            // chartAverageRating
            // 
            this.chartAverageRating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            chartArea2.Name = "ChartArea1";
            this.chartAverageRating.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartAverageRating.Legends.Add(legend2);
            this.chartAverageRating.Location = new System.Drawing.Point(672, 109);
            this.chartAverageRating.Margin = new System.Windows.Forms.Padding(4);
            this.chartAverageRating.Name = "chartAverageRating";
            this.chartAverageRating.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "AvgRating";
            this.chartAverageRating.Series.Add(series2);
            this.chartAverageRating.Size = new System.Drawing.Size(581, 469);
            this.chartAverageRating.TabIndex = 2;
            title2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            title2.ForeColor = System.Drawing.Color.White;
            title2.Name = "Title1";
            title2.Text = "Total score by category";
            this.chartAverageRating.Titles.Add(title2);
            // 
            // btnClose
            // 
            this.btnClose.ActiveImage = null;
            this.btnClose.AllowAnimations = true;
            this.btnClose.AllowBuffering = false;
            this.btnClose.AllowToggling = false;
            this.btnClose.AllowZooming = true;
            this.btnClose.AllowZoomingOnFocus = false;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnClose.ErrorImage")));
            this.btnClose.FadeWhenInactive = false;
            this.btnClose.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageLocation = null;
            this.btnClose.ImageMargin = 20;
            this.btnClose.ImageSize = new System.Drawing.Size(30, 32);
            this.btnClose.ImageZoomSize = new System.Drawing.Size(50, 52);
            this.btnClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnClose.InitialImage")));
            this.btnClose.Location = new System.Drawing.Point(1227, 12);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Rotation = 0;
            this.btnClose.ShowActiveImage = true;
            this.btnClose.ShowCursorChanges = true;
            this.btnClose.ShowImageBorders = true;
            this.btnClose.ShowSizeMarkers = false;
            this.btnClose.Size = new System.Drawing.Size(50, 52);
            this.btnClose.TabIndex = 0;
            this.btnClose.ToolTipText = "";
            this.btnClose.WaitOnLoad = false;
            this.btnClose.ZoomSpeed = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1280, 615);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.chartAverageRating);
            this.Controls.Add(this.chartCategoryCount);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartCategoryCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAverageRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCategoryCount;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAverageRating;
        private Bunifu.UI.WinForms.BunifuImageButton btnClose;
    }
}