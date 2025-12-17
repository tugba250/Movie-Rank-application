using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Drawing;
using System.IO;

namespace FilmIzlemeUygulamasi
{
    public partial class CategoryManagerForm : Form
    {
        private readonly string ConnectionString = "Data Source=movie_db.sqlite;Version=3;";

        public CategoryManagerForm()
        {
            InitializeComponent();
        }

        private void CategoryManagerForm_Load(object sender, EventArgs e)
        {
            LoadCategoriesToGrid();
            AddDeleteButtonColumn(); 
        }

       
        //  UI & DATA 
        

        private void LoadCategoriesToGrid()
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

            
            if (dgvCategories.Columns.Contains("DeleteColumn"))
                dgvCategories.Columns.Remove("DeleteColumn");

            dgvCategories.DataSource = dtCategories;

           
            if (dgvCategories.Columns.Contains("CategoryID"))
                dgvCategories.Columns["CategoryID"].HeaderText = "ID";
            if (dgvCategories.Columns.Contains("CategoryName"))
                dgvCategories.Columns["CategoryName"].HeaderText = "Category Name";
        }

        private void AddDeleteButtonColumn()
        {
            
            if (dgvCategories.Columns.Contains("DeleteColumn"))
                return;

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.HeaderText = "Action";
            deleteButton.Text = "Delete";
            deleteButton.Name = "DeleteColumn";
            deleteButton.UseColumnTextForButtonValue = true;
            dgvCategories.Columns.Add(deleteButton);
        }

        
        //  INSERT 
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newCategory = txtCategoryName.Text.Trim();

            if (string.IsNullOrEmpty(newCategory))
            {
                MessageBox.Show("Category name cannot be empty.", "Validation Error");
                return;
            }

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(ConnectionString))
                {
                    string query = "INSERT INTO Categories (CategoryName) VALUES (@Name)";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", newCategory);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"Category '{newCategory}' added successfully!", "Success");
                txtCategoryName.Clear();
                LoadCategoriesToGrid(); 
                AddDeleteButtonColumn(); 
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UNIQUE constraint failed"))
                {
                    MessageBox.Show($"Category '{newCategory}' already exists.", "Error");
                }
                else
                {
                    MessageBox.Show("Error adding category: " + ex.Message, "Database Error");
                }
            }
        }

        
        //  DELETE
        

        private void dgvCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (dgvCategories.Columns[e.ColumnIndex].Name == "DeleteColumn" && e.RowIndex >= 0)
            {
                int categoryId = Convert.ToInt32(dgvCategories.Rows[e.RowIndex].Cells["CategoryID"].Value);
                string categoryName = dgvCategories.Rows[e.RowIndex].Cells["CategoryName"].Value.ToString();

                DialogResult confirm = MessageBox.Show(
                    $"Are you sure you want to delete category '{categoryName}'?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    DeleteCategory(categoryId);
                }
            }
        }

        private void DeleteCategory(int categoryId)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(ConnectionString))
                {
                    string query = "DELETE FROM Categories WHERE CategoryID = @ID";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", categoryId);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Category deleted successfully.", "Success");
                LoadCategoriesToGrid();
                AddDeleteButtonColumn();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FOREIGN KEY constraint failed"))
                {
                    MessageBox.Show("Cannot delete this category because it is used by existing movies. Please delete associated movies first.", "Deletion Failed");
                }
                else
                {
                    MessageBox.Show("Error deleting category: " + ex.Message, "Database Error");
                }
            }
        }

        
        // FORM MANAGEMENT
        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.OK; 
        }
    }
}