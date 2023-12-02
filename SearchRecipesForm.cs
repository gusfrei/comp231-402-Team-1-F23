using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyCookingApp
{
    public partial class SearchRecipesForm : Form
    {
        string LoginUser = "";
        public SearchRecipesForm(string loginUser="None")
        {
            InitializeComponent();
            LoginUser = loginUser;
        }

        void Connection(string sqlQuery)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string relativePath = @"..\..\..\database\Recipedb.mdf";
            string fullPath = Path.GetFullPath(Path.Combine(currentDirectory, relativePath));
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={fullPath};Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = sqlQuery;
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    DataTable dataTable = new DataTable();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                    
                    search_rcp_datagv.DataSource = dataTable;

                    DataGridViewLinkColumn viewRecipeColumn = new DataGridViewLinkColumn();
                    viewRecipeColumn.HeaderText = "View Recipe";
                    viewRecipeColumn.Name = "View_Recipe";
                    viewRecipeColumn.Text = "View Recipe";
                    viewRecipeColumn.UseColumnTextForLinkValue = true;
                    search_rcp_datagv.Columns.Add(viewRecipeColumn);

                    search_rcp_datagv.CellContentClick += (sender, e) =>
                    {
                        if (e.RowIndex >= 0 && e.ColumnIndex == search_rcp_datagv.Columns["View_Recipe"].Index)
                        {
                            if (LoginUser == "None")
                            {
                                LoginForm loginForm = new LoginForm();
                                loginForm.Show();
                                this.Close();
                            }
                            else if (LoginUser.Contains("admin"))
                            {
                                if (search_rcp_datagv.Rows[e.RowIndex].Cells["RecipeId"].Value != null)
                                {
                                    int recipeId = Convert.ToInt32(search_rcp_datagv.Rows[e.RowIndex].Cells["RecipeId"].Value);
                                    this.Hide();
                                    AddRecipeForm addrecipeform = new AddRecipeForm(LoginUser, recipeId);
                                    addrecipeform.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Recipe ID is not available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                if (search_rcp_datagv.Rows[e.RowIndex].Cells["RecipeId"].Value != null)
                                {
                                    int recipeId = Convert.ToInt32(search_rcp_datagv.Rows[e.RowIndex].Cells["RecipeId"].Value);
                                    ViewRecipeForm viewRecipeForm = new ViewRecipeForm(recipeId);
                                    viewRecipeForm.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Recipe ID is not available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    };
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string searchRecipeName = searchtxbx.Text;
            if (searchRecipeName.Length == 0)
            {
                MessageBox.Show("Please Enter A Recipe Name !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string query = $"SELECT * FROM RecipeTable WHERE LOWER(RecipeName) LIKE LOWER('%{searchRecipeName}%')";
                Connection(query);
            }

        }
    }
}
