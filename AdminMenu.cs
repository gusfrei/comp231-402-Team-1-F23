using Microsoft.Data.SqlClient;
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
    public partial class AdminMenu : Form
    {
        string LoginUser = "";
        public AdminMenu(string loginUser)
        {
            InitializeComponent();
            LoginUser = loginUser;
        }

        private void adm_useradd_btn_Click(object sender, EventArgs e)
        {
            UserAddForm useradd = new UserAddForm(LoginUser);
            useradd.Show();
        }

        private void admn_userrem_btn_Click(object sender, EventArgs e)
        {
            UserAddForm useradd = new UserAddForm(LoginUser);
            useradd.Show();
        }

        private void admin_recadd_btn_Click(object sender, EventArgs e)
        {
            AddRecipeForm addrecipefrom = new AddRecipeForm(LoginUser);
            addrecipefrom.Show();
        }

        private void admn_recprm_btn_Click(object sender, EventArgs e)
        {
            AddRecipeForm addrecipefrom = new AddRecipeForm(LoginUser);
            addrecipefrom.Show();
        }
    }
}
