using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using Bunifu.UI.WinForms;

namespace FilmIzlemeUygulamasi
{
    public partial class MovieCard : UserControl
    {
       
        private readonly string ConnectionString = "Data Source=movie_db.sqlite;Version=3;";

        public int MovieId { get; private set; }

        
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDetails => btnDetail;

        public MovieCard()
        {
            InitializeComponent();
        }

        
        public void LoadData(string title, int year, double rating, int movieId)
        {
            MovieId = movieId;
            lblTitle.Text = title;
            lblYear.Text = $"Year: {year}";
            
            lblRating.Text = $"Rating: {rating:F1}/10";

            LoadPoster(movieId);
        }

        
        // POSTER YÜKLEME VE GÖSTERME
        

       
        /// Veritabanından BLOB poster verisini çekip PictureBox'a yükledi
       
        private void LoadPoster(int movieId)
        {
            byte[] posterData = null;

            
            string query = "SELECT PosterData FROM Movies WHERE MovieID = @MovieID";

            using (SQLiteConnection conn = new SQLiteConnection(ConnectionString))
            using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MovieID", movieId);
                try
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    
                    if (result != DBNull.Value && result != null)
                    {
                        posterData = (byte[])result;
                    }
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error loading poster data: " + ex.Message, "DB Error");
                }
            }

           
            Image posterImage = BlobToImage(posterData);

            if (posterImage != null)
            {
                pbPoster.Image = posterImage;
                pbPoster.SizeMode = PictureBoxSizeMode.Zoom; // Görseli kutuya sığdır
            }
            else
            {
                
                pbPoster.BackColor = Color.Black;
            }
        }

       
        private Image BlobToImage(byte[] posterData)
        {
            if (posterData == null || posterData.Length == 0)
            {
                return null;
            }
            try
            {
                using (MemoryStream ms = new MemoryStream(posterData))
                {
                    
                    return Image.FromStream(ms);
                }
            }
            catch
            {
                
                return null;
            }
        }

    }
}