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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EasyCookingApp
{
    public partial class UserAddForm : Form
    {
        public UserAddForm()
        {
            InitializeComponent();
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
                        if(selection == 2)
                        {
                            reader.Read();
                            usadd_username_txt.Text = reader["userid"].ToString();
                            usadd_password_txt.Text = reader["password"].ToString();
                        }
                        else if(selection == 3)
                        {
                            reader.Read();
                            string loginId = reader["loginid"].ToString();
                            string QueryEx = $"DELETE FROM Credentials WHERE loginid = {int.Parse(loginId)}";
                            Connection(QueryEx,0);
                        }
                    }
                    else if (selection == 1)
                    {
                        MessageBox.Show("User Added Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (selection == 0)
                    {
                        MessageBox.Show("User Removed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        usadd_username_txt.Clear();
                        usadd_password_txt.Clear();
                        usadd_passwrd2_txt.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No Data Found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void useradd_create_btn_Click(object sender, EventArgs e)
        {
            string userName = usadd_username_txt.Text;
            string passWord1 = usadd_password_txt.Text;
            string passWord2 = usadd_passwrd2_txt.Text;

            if (userName.Length == 0 || passWord1.Length == 0)
            {
                MessageBox.Show("User Name or Password is Empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (passWord1 != passWord2)
            {
                MessageBox.Show("Passwords don't match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string query = $"INSERT INTO Credentials (userid, password) " +
                               $"VALUES ('{userName}','{passWord1}')";

                Connection(query,1);
            }
        }

        private void useradd_cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void useradd_search_btn_Click(object sender, EventArgs e)
        {
            string userName = usadd_username_txt.Text;
            if (userName.Length == 0)
            {
                MessageBox.Show("Please provide a valid User Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string query = $"SELECT * FROM Credentials WHERE userid = '{userName}'";
                Connection(query,2);
            }
        }

        private void useradd_remove_btn_Click(object sender, EventArgs e)
        {
            string userName = usadd_username_txt.Text;
            string passWord1 = usadd_password_txt.Text;

            if (userName.Length == 0 || passWord1.Length == 0)
            {
                MessageBox.Show("Please proivde User Name and Password to Remove!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string query = $"SELECT * FROM Credentials WHERE userid = '{userName}' AND password = '{passWord1}'";
                Connection(query,3);
            }
        }
    }
}
