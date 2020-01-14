using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class AddCar : Form
    {
        public AddCar()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MockMenu m = new MockMenu();
            m.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string licensePlate = tbLicensePlateFirstThree.Text + tbLicensePlateRest.Text;
            MessageBox.Show($"{licensePlate}");
           // var add = new Car();
        }

        private void lblAddData_Click(object sender, EventArgs e){}

        private void label1_Click(object sender, EventArgs e){}

        private void clbFuelType_SelectedIndexChanged(object sender, EventArgs e){}

        private void clbFuelType_ItemCheck(object sender, ItemCheckEventArgs e){}

        private void rbtnDiesel_Click(object sender, EventArgs e){}

        private void checkBox1_CheckedChanged(object sender, EventArgs e){}

        
    }
}
