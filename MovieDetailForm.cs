using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Globalization;

namespace FilmIzlemeUygulamasi
{
    public partial class MovieDetailForm : Form
    {
        private readonly string ConnectionString = "Data Source=movie_db.sqlite;Version=3;";
        private int CurrentMovieId;

        // Constructor: ID almalı
        public MovieDetailForm(int movieId)
        {
            InitializeComponent();
            CurrentMovieId = movieId;
        }

        private void MovieDetailForm_Load(object sender, EventArgs e)
        {
            LoadCategoriesToComboBox();
            LoadMovieData(CurrentMovieId); 
        }

        
        

        private void LoadCategoriesToComboBox()
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
                    MessageBox.Show("Error loading categories: " + ex.Message, "Database Error");
                    return;
                }
            }

            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";
            cmbCategory.DataSource = dtCategories;
        }

        private void LoadMovieData(int movieId)
        {
            string query = @"SELECT Title, ReleaseYear, Rating, Summary, CategoryID, PosterURL 
                             FROM Movies 
                             WHERE MovieID = @MovieID";

            using (SQLiteConnection conn = new SQLiteConnection(ConnectionString))
            using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MovieID", movieId);
                conn.Open();

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtTitle.Text = reader["Title"].ToString();
                        txtYear.Text = reader["ReleaseYear"].ToString();

                        
                        double rating = Convert.ToDouble(reader["Rating"]);
                        txtRating.Text = rating.ToString("F1", CultureInfo.InvariantCulture);

                        txtSummary.Text = reader["Summary"].ToString();
                        cmbCategory.SelectedValue = Convert.ToInt32(reader["CategoryID"]);
                    }
                    else
                    {
                        MessageBox.Show("Movie data not found.", "Error");
                        this.Close();
                    }
                }
            }
        }

        
        //  UPDATE / DELETE 
       

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (!ValidateInputs()) return;

            
            string title = txtTitle.Text.Trim();
            int year = Convert.ToInt32(txtYear.Text.Trim());
            double rating = Convert.ToDouble(txtRating.Text.Replace(',', '.'), CultureInfo.InvariantCulture);
            string summary = txtSummary.Text;
            int categoryId = Convert.ToInt32(cmbCategory.SelectedValue);

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(ConnectionString))
                {
                    string query = @"UPDATE Movies SET 
                                     Title = @Title, ReleaseYear = @Year, Rating = @Rating, 
                                     Summary = @Summary, CategoryID = @CategoryID 
                                     WHERE MovieID = @MovieID";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Title", title);
                        cmd.Parameters.AddWithValue("@Year", year);
                        cmd.Parameters.AddWithValue("@Rating", rating);
                        cmd.Parameters.AddWithValue("@Summary", summary);
                        cmd.Parameters.AddWithValue("@CategoryID", categoryId);
                        cmd.Parameters.AddWithValue("@MovieID", CurrentMovieId);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Movie updated successfully!", "Success");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating movie: " + ex.Message, "Database Error");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show($"Are you sure you want to delete '{txtTitle.Text}'?",
                                                   "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (SQLiteConnection conn = new SQLiteConnection(ConnectionString))
                    {
                        string query = "DELETE FROM Movies WHERE MovieID = @MovieID";
                        using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@MovieID", CurrentMovieId);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Movie deleted successfully!", "Success");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting movie: " + ex.Message, "Database Error");
                }
            }
        }

        
        //  UI & NAVIGATION
        

        private void btnManageCategory_Click(object sender, EventArgs e)
        {
            CategoryManagerForm categoryManager = new CategoryManagerForm();
            
            if (categoryManager.ShowDialog() == DialogResult.OK)
            {
                LoadCategoriesToComboBox();
                LoadMovieData(CurrentMovieId); 
            }
        }

        private bool ValidateInputs()
        {
            
            if (string.IsNullOrEmpty(txtTitle.Text) || !int.TryParse(txtYear.Text, out _) || !double.TryParse(txtRating.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out _) || cmbCategory.SelectedValue == null)
            {
                MessageBox.Show("Please ensure Title, Year, Rating are valid, and a Category is selected.", "Validation Error");
                return false;
            }
            return true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}