using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class MockMenu : Form
    {
        public MockMenu()
        {
            InitializeComponent();
        }

        private void btnCarList_Click(object sender, EventArgs e)
        {
            this.Hide();
            CarList c = new CarList();
            c.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCar c = new AddCar();
            c.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
