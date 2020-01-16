using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class UpdateCar : Form
    {


        private readonly Car car; 

        public UpdateCar(Car car)
        {
            this.car = car;
            InitializeComponent();
        }
        


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string fuel = ManagerApp.WhichFuel(rbtnDiesel.Checked, rbtnGasoline.Checked);

            double price = ManagerApp.CombinePrice(numUpDownPricePerDay.Value, numUpDownPricePerDayAfterComa.Value);

            Car car = new Car(tbLicensePlate.Text, tbBrand.Text, tbModel.Text, tbColor.Text, Convert.ToInt32(numUpDownMileage.Value), Convert.ToInt32(numUpDownYear.Value),
                tbEngine.Text, fuel, combobxTransmission.Text, price, combobxCaretaker.Text);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void UpdateCar_Load(object sender, EventArgs e)
        {
            tbLicensePlate.Text = car.LicensePlate;
            tbBrand.Text = car.Brand;
            tbModel.Text = car.Model;
            tbColor.Text = car.Color;
            numUpDownMileage.Value = car.Mileage;
            numUpDownYear.Value = car.ProductionYear;
            tbEngine.Text = car.Engine;

            if (car.FuelType == "Diesel")
            {
                rbtnDiesel.Checked = true;
                rbtnGasoline.Checked = false;
                rbtnGas.Checked = false;
            }
            else if (car.FuelType == "Gasoline")
                rbtnGasoline.Checked = true;
            else if (car.FuelType == "Gas")
                rbtnGas.Checked = true;

            if (car.Transmission == "Manual")
                combobxTransmission.SelectedIndex = 0;
            else combobxTransmission.SelectedIndex = 1;

            numUpDownPricePerDay.Value = (int) car.PricePerDay;
            numUpDownPricePerDayAfterComa.Value = Convert.ToInt32(Math.Truncate(car.PricePerDay));
        }


        private void label1_Click(object sender, EventArgs e) { }

        private void rbtnDiesel_Click(object sender, EventArgs e) { }
    }
}
