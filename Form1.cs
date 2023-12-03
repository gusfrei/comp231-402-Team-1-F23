using System;

namespace EasyCookingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hpgloginbtn_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
        }

        private void hmpgrecipebtn_Click(object sender, EventArgs e)
        {
            SearchRecipesForm form = new SearchRecipesForm();
            form.Show();
        }

    }
}