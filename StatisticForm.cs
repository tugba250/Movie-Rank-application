using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using System.Collections.Generic;

namespace FilmIzlemeUygulamasi
{
    public partial class StatisticsForm : Form
    {
        private readonly string ConnectionString = "Data Source=movie_db.sqlite;Version=3;";

        public StatisticsForm()
        {
            InitializeComponent();
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            
            LoadCategoryCountChart();
            LoadAverageRatingChart();
        }

        
        // KATEGORİ SAYISI GRAFİĞİ (Pie/Doughnut)
        

        private void LoadCategoryCountChart()
        {
            DataTable dt = new DataTable();
           
            string query = @"
                SELECT c.CategoryName, COUNT(m.MovieID) as MovieCount
                FROM Movies m
                JOIN Categories c ON m.CategoryID = c.CategoryID
                GROUP BY c.CategoryName
                HAVING COUNT(m.MovieID) > 0
                ORDER BY MovieCount DESC";

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(ConnectionString))
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    conn.Open();
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }

                
                if (dt.Rows.Count == 0)
                {
                   
                    chartCategoryCount.Titles[0].Text = "Film Bulunamadı. Lütfen Film Ekleyin.";
                    chartCategoryCount.Series.Clear();
                    return;
                }

                chartCategoryCount.Series.Clear();
                Series series = new Series("MovieCount")
                {
                    ChartType = SeriesChartType.Doughnut,
                    IsValueShownAsLabel = true,
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold)
                };

                foreach (DataRow row in dt.Rows)
                {
                    series.Points.AddXY(row["CategoryName"].ToString(), Convert.ToInt32(row["MovieCount"]));
                }

                chartCategoryCount.Series.Add(series);

               
                chartCategoryCount.ChartAreas[0].BackColor = Color.Transparent;
                chartCategoryCount.Legends[0].BackColor = Color.Transparent;
                chartCategoryCount.Legends[0].ForeColor = Color.White;
                chartCategoryCount.Titles[0].Text = "Category Distribution by Number of Films";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Category Count Chart: " + ex.Message, "Statistics Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        //  ORTALAMA PUAN GRAFİĞİ 
       

        private void LoadAverageRatingChart()
        {
            DataTable dt = new DataTable();
           
            string query = @"
                SELECT c.CategoryName, AVG(m.Rating) as AvgRating
                FROM Movies m
                JOIN Categories c ON m.CategoryID = c.CategoryID
                GROUP BY c.CategoryName
                HAVING COUNT(m.MovieID) > 0
                ORDER BY AvgRating DESC";

            try 
            {
                using (SQLiteConnection conn = new SQLiteConnection(ConnectionString))
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    conn.Open();
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }

                if (dt.Rows.Count == 0)
                {
                    chartAverageRating.Titles[0].Text = "Puan Ortalaması İçin Yeterli Film Yok.";
                    chartAverageRating.Series.Clear();
                    return;
                }

                chartAverageRating.Series.Clear();
                Series series = new Series("AvgRating")
                {
                    ChartType = SeriesChartType.Column, 
                    IsValueShownAsLabel = true,
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                    Color = Color.FromArgb(255, 180, 0) 
                };

                foreach (DataRow row in dt.Rows)
                {
                    double rating = Math.Round(Convert.ToDouble(row["AvgRating"]), 2); 
                    series.Points.AddXY(row["CategoryName"].ToString(), rating);
                }

                chartAverageRating.Series.Add(series);

                
                chartAverageRating.ChartAreas[0].BackColor = Color.Transparent;
                chartAverageRating.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.FromArgb(64, 64, 64);
                chartAverageRating.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.FromArgb(64, 64, 64);
                chartAverageRating.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
                chartAverageRating.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
                chartAverageRating.Legends[0].Enabled = false;
                chartAverageRating.Titles[0].Text = "Total score by category" +
                    "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Average Rating Chart: " + ex.Message, "Statistics Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}