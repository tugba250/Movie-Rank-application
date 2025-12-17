using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Globalization;

namespace FilmIzlemeUygulamasi
{
    public partial class MovieAddForm : Form
    {
        private readonly string ConnectionString = "Data Source=movie_db.sqlite;Version=3;";

        public MovieAddForm()
        {
            InitializeComponent();
        }

        private void MovieAddForm_Load(object sender, EventArgs e)
        {
            LoadCategoriesToComboBox();
        }

        
        // DATA ACCESS & LOADING
       

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

       
        //  BLOB YÖNETİMİ 
       

        private void btnBrowsePoster_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp",
                Title = "Select Movie Poster"
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Resmi PictureBox'a yükledim
                    pbPoster.Image = Image.FromFile(ofd.FileName);
                    pbPoster.SizeMode = PictureBoxSizeMode.Zoom;
                    // Dosya yolunu kaydet (BLOB'a dönüştürüyor bu)
                    lblPosterPath.Text = ofd.FileName;
                }
            }
        }

     
        // Seçilen görsel dosyasını byte dizisine (BLOB) dönüştürmek için gerekiyor.
      
        private byte[] ImageToBlob(string imagePath)
        {
            if (string.IsNullOrEmpty(imagePath) || !File.Exists(imagePath))
            {
               
                return null;
            }
            try
            {
                return File.ReadAllBytes(imagePath);
            }
            catch
            {
                return null;
            }
        }

       
        //  INSERT LOGIC (CREATE)
      

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            string title = txtTitle.Text.Trim();
            int year = Convert.ToInt32(txtYear.Text.Trim());
           
            double rating = Convert.ToDouble(txtRating.Text.Replace(',', '.'), CultureInfo.InvariantCulture);
            string summary = txtSummary.Text;
            int categoryId = Convert.ToInt32(cmbCategory.SelectedValue);

            
            string posterPath = lblPosterPath.Text;
            byte[] posterData = ImageToBlob(posterPath);

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(ConnectionString))
                {
                    
                    string query = @"INSERT INTO Movies 
                                     (Title, ReleaseYear, Rating, Summary, PosterURL, PosterData, CategoryID) 
                                     VALUES (@Title, @Year, @Rating, @Summary, @PosterURL, @PosterData, @CategoryID)";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Title", title);
                        cmd.Parameters.AddWithValue("@Year", year);
                        cmd.Parameters.AddWithValue("@Rating", rating);
                        cmd.Parameters.AddWithValue("@Summary", summary);
                        cmd.Parameters.AddWithValue("@PosterURL", string.Empty);
                        cmd.Parameters.AddWithValue("@PosterData", posterData); // BLOB verisi
                        cmd.Parameters.AddWithValue("@CategoryID", categoryId);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Movie saved successfully!", "Success");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving movie: " + ex.Message, "Database Error");
            }
        }

        
        //  VALIDATION AND UI
        

        private void btnManageCategory_Click(object sender, EventArgs e)
        {
            CategoryManagerForm categoryManager = new CategoryManagerForm();
            if (categoryManager.ShowDialog() == DialogResult.OK)
            {
                LoadCategoriesToComboBox(); 
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                MessageBox.Show("Title cannot be empty.", "Validation Error");
                txtTitle.Focus();
                return false;
            }
            if (!int.TryParse(txtYear.Text, out _))
            {
                MessageBox.Show("Please enter a valid Release Year.", "Validation Error");
                txtYear.Focus();
                return false;
            }
            if (!double.TryParse(txtRating.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out _))
            {
                MessageBox.Show("Please enter a valid Rating (e.g., 8.5).", "Validation Error");
                txtRating.Focus();
                return false;
            }
            if (cmbCategory.SelectedValue == null)
            {
                MessageBox.Show("Please select a category.", "Validation Error");
                cmbCategory.Focus();
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