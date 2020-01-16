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
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string fuel = ManagerApp.WhichFuel(rbtnDiesel.Checked, rbtnGasoline.Checked);

            double price = ManagerApp.CombinePrice(numUpDownPricePerDay.Value, numUpDownPricePerDayAfterComa.Value);

            Car car = new Car(tbLicensePlate.Text, tbBrand.Text, tbModel.Text, tbColor.Text, Convert.ToInt32(numUpDownMileage.Value), Convert.ToInt32(numUpDownYear.Value),
                tbEngine.Text, fuel, cbxTransmission.Text, price, cbxCaretaker.Text);
        }

        private void lblAddData_Click(object sender, EventArgs e){}

        private void label1_Click(object sender, EventArgs e){}

        private void clbFuelType_SelectedIndexChanged(object sender, EventArgs e){}

        private void clbFuelType_ItemCheck(object sender, ItemCheckEventArgs e){}

        private void rbtnDiesel_Click(object sender, EventArgs e){}

        private void checkBox1_CheckedChanged(object sender, EventArgs e){}

        
    }
}
