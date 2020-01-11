using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private bool Validate(string login, string password)
        {
            if (login is "Jan" && password is "test")
                return true;
            else
                return false;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (Validate(tbLogin.Text, tbPassword.Text))
            {
                this.Hide();
                CarMenu m = new CarMenu();
                m.Show();
            }
            else
                MessageBox.Show("Wrong password or login");

        }
    }
}
