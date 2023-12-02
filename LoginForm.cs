using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client.Platforms.Features.DesktopOs.Kerberos;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyCookingApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
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
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        String loginUser = reader["userid"].ToString();
                        MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();

                        if (loginUser.Contains("admin"))
                        {
                            AdminMenu adminMenu = new AdminMenu(loginUser);
                            adminMenu.Show(this);
                        }
                        else
                        {
                            SearchRecipesForm searchrecipeform = new SearchRecipesForm(loginUser);
                            searchrecipeform.Show(this);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    reader.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid Login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void loginbtn_Click(object sender, EventArgs e)
        {
            string userName = this.userIdtbx.Text;
            string passWord = this.pwdtxbx.Text;

            if (userName.Length == 0 || passWord.Length == 0)
            {
                MessageBox.Show("User Name or Password is Empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string query = $"SELECT * FROM Credentials WHERE userid = '{userName}' AND password = '{passWord}'";
                Connection(query);
            }
        }

        private void bckbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
