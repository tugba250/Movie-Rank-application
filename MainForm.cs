using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Drawing;

namespace FilmIzlemeUygulamasi
{
    public partial class MainForm : Form
    {
        private readonly string ConnectionString = "Data Source=movie_db.sqlite;Version=3;";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
            FilterMovies(); 
        }

       
        //  DATA ACCESS METHODS
        

        private DataTable GetCategories()
        {
            DataTable dtCategories = new DataTable();
            string query = "SELECT CategoryID, CategoryName FROM Categories ORDER BY CategoryName";

            using (SQLiteConnection conn = new SQLiteConnection(ConnectionString))
            using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
            {
                try
                {
                    conn.Open();
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                    {
                        da.Fill(dtCategories);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching categories: " + ex.Message, "Database Error");
                }
            }
            return dtCategories;
        }

        // Id ve aramaya göre film çeker.
        private DataTable GetFilteredMovies(int categoryId, string searchTerm)
        {
            DataTable dt = new DataTable();
            string query = @"
                SELECT MovieID, Title, ReleaseYear, Rating, Summary 
                FROM Movies
                WHERE 1 = 1 ";

            List<SQLiteParameter> parameters = new List<SQLiteParameter>();

            if (categoryId > 0)
            {
                query += " AND CategoryID = @categoryId";
                parameters.Add(new SQLiteParameter("@categoryId", categoryId));
            }

            if (!string.IsNullOrEmpty(searchTerm))
            {
                query += " AND Title LIKE @searchTerm";
                parameters.Add(new SQLiteParameter("@searchTerm", "%" + searchTerm + "%"));
            }

            using (SQLiteConnection conn = new SQLiteConnection(ConnectionString))
            using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddRange(parameters.ToArray());
                try
                {
                    conn.Open();
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error filtering movies: " + ex.Message, "Database Error");
                }
            }
            return dt;
        }


        
        //  UI LOGIC METHODS 
        

        private void LoadCategories()
        {
            DataTable dtCategories = GetCategories();

            // "All Categories" (Tüm Kategoriler) seçeneğini ekle
            DataRow allRow = dtCategories.NewRow();
            allRow["CategoryID"] = 0;
            allRow["CategoryName"] = "All Categories";
            dtCategories.Rows.InsertAt(allRow, 0);

            lbCategories.DisplayMember = "CategoryName";
            lbCategories.ValueMember = "CategoryID";
            lbCategories.DataSource = dtCategories;
        }

        // Bu veri tabanından gelen her satır için MovieCard oluşturur
        private void LoadFilmCards(DataTable sourceData)
        {
            flowLayoutPanelMovies.Controls.Clear();

            if (sourceData == null || sourceData.Rows.Count == 0)
            {
                // Film bulunamadığında kullanıcıya bilgi verme
                Label lbl = new Label()
                {
                    Text = "No movies found matching the criteria.",
                    ForeColor = Color.Silver,
                    AutoSize = true,
                    Font = new Font("Segoe UI", 12F)
                };
                flowLayoutPanelMovies.Controls.Add(lbl);
                return;
            }

            foreach (DataRow row in sourceData.Rows)
            {
                MovieCard card = new MovieCard();

                // MovieCard'daki LoadData metodunu kullanarak verileri karta yükledim
                card.LoadData(
                    row["Title"].ToString(),
                    Convert.ToInt32(row["ReleaseYear"]),
                    Convert.ToDouble(row["Rating"]),
                    Convert.ToInt32(row["MovieID"])
                );

               
                card.btnDetails.Click += (s, ev) => OpenDetailForm(card.MovieId);

                flowLayoutPanelMovies.Controls.Add(card);
            }
        }

        
        private void FilterMovies()
        {
            int categoryId = 0;
            
            if (lbCategories.SelectedValue != null && lbCategories.SelectedValue != DBNull.Value)
            {
                categoryId = Convert.ToInt32(lbCategories.SelectedValue);
            }

            string searchTerm = txtSearch.Text;

            DataTable filteredData = GetFilteredMovies(categoryId, searchTerm);
            LoadFilmCards(filteredData);
        }

        private void OpenDetailForm(int movieId)
        {
            
            MovieDetailForm detailForm = new MovieDetailForm(movieId);

            
            if (detailForm.ShowDialog() == DialogResult.OK)
            {
                
                FilterMovies();
            }
            
        }


       
        //  EVENT HANDLERS 
        
        private void lbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbCategories.SelectedValue != null)
            {
                FilterMovies(); 
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterMovies(); 
        }
        private void btnStatistics_Click(object sender, EventArgs e)
        {
            
            StatisticsForm statisticsForm = new StatisticsForm();
            statisticsForm.ShowDialog(); 
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            
            MovieAddForm addForm = new MovieAddForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                FilterMovies(); 
            }
        }

        // MainForm.cs

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}