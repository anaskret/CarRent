using CarRent.Models.Dtos;
using CarRent.DataAccess;
using CarRent.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using CarRent.App;

namespace Project
{
    public partial class AddOrUpdateCar : Form
    {
        private readonly CarService car;
        private readonly bool isUpdate;

        public AddOrUpdateCar(bool isUpdate)
        {
            InitializeComponent();
        }
        public AddOrUpdateCar(CarService car, bool isUpdate)
        {
            this.car = car;
            this.isUpdate = isUpdate;
            InitializeComponent();
        }


        private void AddUpdateCar_Load(object sender, EventArgs e)
        {
            if (isUpdate == true)
            {
                lblAddData.Text = "Update Data";
                btnAdd.Text = "Update";
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
                    cbxTransmission.SelectedIndex = 0;
                else cbxTransmission.SelectedIndex = 1;

                numUpDownPricePerDay.Value = (int)car.PricePerDay;
                numUpDownPricePerDayAfterComa.Value = Convert.ToInt32(Math.Truncate(car.PricePerDay));
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Dodawanie/Modyfikowanie
            if (!AllFilled())
                return;

            var provider = new Dependencies().Load();
            ICarService carService = provider.GetService<ICarService>();
            var car = AddCarFromForm();

            carService.AddCar(1, car);

            if (!isUpdate)
            {
               
            }
            this.Hide();
        }
         
        private AddCarDto AddCarFromForm()
        {
            var addCar = new AddCarDto();


            string fuel = ManagerApp.WhichFuel(rbtnDiesel.Checked, rbtnGasoline.Checked);

            decimal price = ManagerApp.CombinePrice(numUpDownPricePerDay.Value, numUpDownPricePerDayAfterComa.Value);

            addCar.LicensePlateNumber = tbLicensePlate.Text;
            addCar.Brand = tbBrand.Text;
            addCar.Model = tbModel.Text;
            addCar.Color = tbColor.Text;
            addCar.Mileage = Convert.ToInt32(numUpDownMileage.Value);
            addCar.Year = Convert.ToInt32(numUpDownYear.Value);
            addCar.Engine = tbEngine.Text;
            addCar.FuelType = fuel;
            addCar.Transmission = cbxTransmission.Text;
            addCar.PricePerDay = price;

            return addCar;
        }

        private bool AllFilled()
        {
            if (tbLicensePlate.TextLength < 6)
            {
                MessageBox.Show("Type License Plate Number");
                return false; 
            }
            if(tbBrand.TextLength < 2)
            {
                MessageBox.Show("Type Brand");
                return false;
            }
            if(tbModel.TextLength < 2)
            {
                MessageBox.Show("Type Model");
                return false;
            }
            if(tbEngine.TextLength == 0)
            {
                MessageBox.Show("Type Engine");
                return false;
            }
            if(cbxTransmission.SelectedItem == null)
            {
                MessageBox.Show("Choose Transmission Type");
                return false;
            }
            if(tbColor.TextLength < 3 )
            {
                MessageBox.Show("Type Color");
                return false;
            }
            if (rbtnDiesel.Checked == false && rbtnGas.Checked == false && rbtnGasoline.Checked == false)
            {
                MessageBox.Show("Choose Fuel Type");
                return false;
            }
            return true;
        }


        private void lblAddData_Click(object sender, EventArgs e){}

        private void label1_Click(object sender, EventArgs e){}

        private void clbFuelType_SelectedIndexChanged(object sender, EventArgs e){}

        private void clbFuelType_ItemCheck(object sender, ItemCheckEventArgs e){}

        private void rbtnDiesel_Click(object sender, EventArgs e){}

        private void checkBox1_CheckedChanged(object sender, EventArgs e){}

        
    }
}
