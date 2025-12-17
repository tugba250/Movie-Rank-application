using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Data;
using Bunifu.UI.WinForms; 

namespace FilmIzlemeUygulamasi
{
    public partial class LoginForm : Form
    {
        
        private readonly string DbName = "movie_db.sqlite";
        private readonly string ConnectionString;

        public LoginForm()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            ConnectionString = $"Data Source={DbName};Version=3;";
            this.btnSignUp.Font = new System.Drawing.Font(this.btnSignUp.Font.FontFamily,  14, System.Drawing.FontStyle.Bold );
        }

        
        //  VERİTABANI BAŞLATMA 
        

      
        private void LoginForm_Load(object sender, EventArgs e)
        {
            
            CreateDatabaseFileAndTables();
        }

        private void CreateDatabaseFileAndTables()
        { 
        
         
            try
            {
                
                if (!File.Exists(DbName))
                {
                    SQLiteConnection.CreateFile(DbName);
                }

               
                using (var SQLconnect = new SQLiteConnection(ConnectionString))
                {
                    SQLconnect.Open();
                    using (var SQLCommand = SQLconnect.CreateCommand())
                    {
                        
                        SQLCommand.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Users(ID INTEGER PRIMARY KEY AUTOINCREMENT, Username TEXT NOT NULL UNIQUE, Password TEXT NOT NULL);
                    CREATE TABLE IF NOT EXISTS Categories(CategoryID INTEGER PRIMARY KEY AUTOINCREMENT, CategoryName TEXT NOT NULL UNIQUE);
                    CREATE TABLE IF NOT EXISTS Movies(
                        MovieID INTEGER PRIMARY KEY AUTOINCREMENT, 
                        Title TEXT NOT NULL, 
                        ReleaseYear INTEGER, 
                        Rating REAL, 
                        Summary TEXT, 
                        PosterURL TEXT, 
                        PosterData BLOB, 
                        CategoryID INTEGER,
                        FOREIGN KEY(CategoryID) REFERENCES Categories(CategoryID)
                    );";
                        SQLCommand.ExecuteNonQuery();

                        

                        
                        SQLCommand.CommandText = "SELECT COUNT(*) FROM Users";
                        long userCount = (long)SQLCommand.ExecuteScalar();

                        if (userCount == 0)
                        {
                            //Varsayılan yaptım
                            SQLCommand.CommandText = "INSERT INTO Users (Username, Password) VALUES ('Tuğba', '1234')";
                            SQLCommand.ExecuteNonQuery();
                           
                        }

                        
                        SQLCommand.CommandText = "SELECT COUNT(*) FROM Categories";
                        long categoryCount = (long)SQLCommand.ExecuteScalar();

                        if (categoryCount == 0)
                        {
                           
                            SQLCommand.CommandText = "INSERT INTO Categories (CategoryName) VALUES ('Action'), ('Drama'), ('Comedy'), ('Sci-Fi'), ('Horror')";
                            SQLCommand.ExecuteNonQuery();
                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database setup failed. Error: " + ex.Message, "Critical Error");
            }
        }
   

       
      
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre giriniz.", "Hata");
                return;
            }

            if (CheckCredentials(username, password))
            {
                // Başarılı giriş
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.", "Giriş Başarısız");
            }
        }

        private bool CheckCredentials(string username, string password)
        {
            using (SQLiteConnection con = new SQLiteConnection(ConnectionString))
            {
                string query = "SELECT COUNT(1) FROM Users WHERE Username = @u AND Password = @p";
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@p", password);
                    con.Open();
                    // Sorgu sonucu long tipinde döner
                    long count = (long)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // Register formuna yönlendirme
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}