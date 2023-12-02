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
using OfficeOpenXml;

namespace EasyCookingApp
{
    public partial class ViewRecipeForm : Form
    {
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
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        viewrcp_catrcp_txt.Text = reader["RecipeCategory"].ToString();
                        viewrcp_namercp_txt.Text = reader["RecipeName"].ToString();
                        viewrcp_stepbstp_txb.Text = reader["RecipeInstruction"].ToString();
                        viewrcp_usercommts_txb.Text = reader["RecipeComments"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Recipe not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        int RECIPE_ID;
        public ViewRecipeForm(int Recipe_id)
        {
            InitializeComponent();
            RECIPE_ID = Recipe_id;
            string query = $"SELECT * FROM RecipeTable WHERE RecipeId = {Recipe_id}";
            Connection(query);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string viewComments = viewrcp_usercommts_txb.Text;
            if (viewComments == null || viewComments.Length == 0)
            {
                MessageBox.Show("Please Enter A Valid Comment !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string query = $"UPDATE RecipeTable SET RecipeComments = '{viewComments}' WHERE RecipeId = {RECIPE_ID}";
                Connection(query);
                MessageBox.Show("Your Comments has been updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void viewrcp_cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExportToExcel()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files|*.xlsx|All Files|*.*",
                Title = "Save Excel File",
                FileName = "RecipeData.xlsx"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo newFile = new FileInfo(saveFileDialog.FileName);
                using (ExcelPackage package = new ExcelPackage(newFile))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("RecipeData");

                    FillWorksheetWithData(worksheet);
                    package.Save();
                }
                MessageBox.Show("Data exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FillWorksheetWithData(ExcelWorksheet worksheet)
        {
            worksheet.Cells["A1"].Value = "Recipe Category";
            worksheet.Cells["B1"].Value = "Recipe Name";
            worksheet.Cells["C1"].Value = "Recipe Instruction";
            worksheet.Cells["D1"].Value = "Recipe Comments";

            worksheet.Cells["A2"].Value = viewrcp_catrcp_txt.Text;
            worksheet.Cells["B2"].Value = viewrcp_namercp_txt.Text;
            worksheet.Cells["C2"].Value = viewrcp_stepbstp_txb.Text;
            worksheet.Cells["D2"].Value = viewrcp_usercommts_txb.Text;
        }

        private void viewrcp_export_btn_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }
    }
}

