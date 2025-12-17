using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace FilmIzlemeUygulamasi
{
    public partial class RegisterForm : Form
    {
        private readonly string ConnectionString = "Data Source=movie_db.sqlite;Version=3;";

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtRegUsername.Text.Trim();
            string password = txtRegPassword.Text;

            
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error");
                return;
            }

            try
            {
                using (SQLiteConnection con = new SQLiteConnection(ConnectionString))
                {
                    string query = "INSERT INTO Users (Username, Password) VALUES (@u, @p)";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@u", username);
                        cmd.Parameters.AddWithValue("@p", password);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Registration successful! Please login.", "Success");

               
                LoginForm loginForm = new LoginForm();
                this.Hide();
                loginForm.Show();

            }
            catch (SQLiteException ex)
            {
                
                if (ex.ErrorCode == 19)
                {
                    MessageBox.Show("This username is already taken. Please try another one.", "Registration Error");
                }
                else
                {
                    MessageBox.Show("Database error occurred: " + ex.Message, "Error");
                }
            }
        }

        
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}