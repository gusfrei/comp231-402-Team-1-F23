using System;
using System.IO;
using Microsoft.Data.SqlClient;

namespace EasyCookingApp
{
    public partial class AddRecipeForm : Form
    {
        string LoginUser = "";
        int RecipeID = 0;
        public AddRecipeForm(string loginUser, int recipeId = 0)
        {
            InitializeComponent();
            LoginUser = loginUser;
            RecipeID = recipeId;
            if (recipeId > 0)
            {
                string query = $"SELECT * FROM RecipeTable WHERE RecipeId = {recipeId}";
                Connection(query, 2);
            }
        }

        void Connection(string sqlQuery, int selection)
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
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        if (selection == 2)
                        {
                            reader.Read();
                            addrcp_catrcp_txt.Text = reader["RecipeCategory"].ToString();
                            addrcp_namercp_txt.Text = reader["RecipeName"].ToString();
                            addrcp_stepbstp_txb.Text = reader["RecipeInstruction"].ToString();
                            addrcp_usercommts_txb.Text = reader["RecipeComments"].ToString();
                        }
                    }
                    else if (selection == 1)
                    {
                        MessageBox.Show("New Recipe Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        addrcp_catrcp_txt.Clear();
                        addrcp_namercp_txt.Clear();
                        addrcp_stepbstp_txb.Clear();
                        addrcp_usercommts_txb.Clear();
                    }
                    else if (selection == 3)
                    {
                        MessageBox.Show("Recipe Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        addrcp_catrcp_txt.Clear();
                        addrcp_namercp_txt.Clear();
                        addrcp_stepbstp_txb.Clear();
                        addrcp_usercommts_txb.Clear();
                    }
                    else if (selection == 4)
                    {
                        MessageBox.Show("Recipe Removed Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        addrcp_catrcp_txt.Clear();
                        addrcp_namercp_txt.Clear();
                        addrcp_stepbstp_txb.Clear();
                        addrcp_usercommts_txb.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Transaction was UnSuccessful", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void addrcp_creatercp_btn_Click(object sender, EventArgs e)
        {
            string recipeName = addrcp_namercp_txt.Text;
            if (recipeName.Length == 0)
            {
                MessageBox.Show("Please Enter A Recipe Name !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string recipeCategory = addrcp_catrcp_txt.Text;
            if (recipeCategory.Length == 0)
            {
                MessageBox.Show("Please Enter A Recipe Category !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string recipeInstructions = addrcp_stepbstp_txb.Text;
            if (recipeInstructions.Length == 0)
            {
                MessageBox.Show("Please Enter A Recipe Instruction !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string recipeComments = addrcp_usercommts_txb.Text;
            if (recipeComments.Length == 0)
            {
                recipeComments = "Newly added Recipe!";
            }

            string query = $"INSERT INTO RecipeTable (RecipeCategory, RecipeName, RecipeInstruction, RecipeComments) " +
                 $"VALUES ('{recipeCategory}','{recipeName}','{recipeInstructions}','{recipeComments}')";

            Connection(query, 1);
        }

        private void addrcp_search_btn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SearchRecipesForm searchRecipesForm = new SearchRecipesForm(LoginUser);
            searchRecipesForm.Show();
        }

        private void addrcp_edit_btn_Click(object sender, EventArgs e)
        {
            string recipeName = addrcp_namercp_txt.Text;
            if (recipeName.Length == 0)
            {
                MessageBox.Show("Please Enter A Recipe Name !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string recipeCategory = addrcp_catrcp_txt.Text;
            if (recipeCategory.Length == 0)
            {
                MessageBox.Show("Please Enter A Recipe Category !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string recipeInstructions = addrcp_stepbstp_txb.Text;
            if (recipeInstructions.Length == 0)
            {
                MessageBox.Show("Please Enter A Recipe Instruction !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string recipeComments = addrcp_usercommts_txb.Text;
            if (recipeComments.Length == 0)
            {
                recipeComments = "Newly Edited Recipe!";
            }

            string query = $"UPDATE RecipeTable SET RecipeCategory = '{recipeCategory}', RecipeName = '{recipeName}', " +
                           $"RecipeInstruction = '{recipeInstructions}', RecipeComments = '{recipeComments}' WHERE RecipeId = {RecipeID}";

            Connection(query, 3);
        }

        private void addrcp_remove_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure? Press 'OK' to proceed, or 'Cancel' to abort!", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                string Query = $"DELETE FROM RecipeTable WHERE RecipeId = {RecipeID}";
                Connection(Query, 4);
            }
            else
            {
                MessageBox.Show("No Action Taken !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void addrcp_cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
