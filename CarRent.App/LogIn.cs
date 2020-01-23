using CarRent.App;
using CarRent.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using CarRent.Services.Interfaces;

namespace Project
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }


        private void btnLogIn_Click(object sender, EventArgs e)
        {
            var provider = new Dependencies().Load();
            var validate = provider.GetService<ICoordinatorService>();

            if (validate.ValidateLogin(tbLogin.Text, tbPassword.Text))
            {
                this.Hide();
                Menu m = new Menu();
                m.Show();
            }
            else
            { 
                MessageBox.Show("Wrong password or login");
                tbPassword.Text = "";
            }

        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowHide.Checked)
            {
                tbPassword.UseSystemPasswordChar = false;
                cbShowHide.Text = "Hide Password";
            }
            else
            {
                tbPassword.UseSystemPasswordChar = true;
                cbShowHide.Text = "Show Password";
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            AddData.SeedData();
        }
    }
}
