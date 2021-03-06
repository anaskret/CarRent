﻿using CarRent.Models.Dtos;
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
        private readonly UpdateCarDto car;
        private readonly bool isUpdate;
        private readonly int id;

        public AddOrUpdateCar(bool isUpdate)
        {
            this.isUpdate = isUpdate;
            InitializeComponent();
        }

        public AddOrUpdateCar(UpdateCarDto car, bool isUpdate, int id)
        {
            this.car = car;
            this.isUpdate = isUpdate;
            this.id = id;
            InitializeComponent();
        }


        private void AddUpdateCar_Load(object sender, EventArgs e)
        {

            if (isUpdate == true)
            {
                lblAddData.Text = "Update Data";
                btnAdd.Text = "Update";
                tbxLicensePlate.Text = car.LicensePlateNumber;
                tbxBrand.Text = car.Brand;
                tbxModel.Text = car.Model;
                tbxColor.Text = car.Color;
                numUpDownMileage.Value = car.Mileage;
                numUpDownYear.Value = car.Year;
                tbxEngine.Text = car.Engine;

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
                decimal decimalPrice = Math.Truncate(car.PricePerDay);
                numUpDownPricePerDayAfterComa.Value = decimalPrice - car.PricePerDay;
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Dodawanie/Modyfikowanie

            var provider = new Dependencies().Load();
            ICarService carService = provider.GetService<ICarService>();

            if (isUpdate)
            {
                var carUpdate = UpdateCarFromForm();
                if (!carUpdate.Validate())
                {
                    MessageBox.Show("Validation error");
                    return; 
                }
                carService.UpdateCar(id, carUpdate);

                this.Hide();

            }
            else
            {
                var carAdd = AddCarFromForm();
                if (!carAdd.Validate())
                {
                    MessageBox.Show("Validation error");
                    return;
                }
                carService.AddCar(carAdd);


                this.Hide();
            }
        }
         
        private AddCarDto AddCarFromForm()
        {
            var addCar = new AddCarDto();


            string fuel = CarManager.WhichFuel(rbtnDiesel.Checked, rbtnGasoline.Checked);

            decimal price = CarManager.CombinePrice(numUpDownPricePerDay.Value, numUpDownPricePerDayAfterComa.Value);

            addCar.LicensePlateNumber = tbxLicensePlate.Text;
            addCar.Brand = tbxBrand.Text;
            addCar.Model = tbxModel.Text;
            addCar.Color = tbxColor.Text;
            addCar.Mileage = Convert.ToInt32(numUpDownMileage.Value);
            addCar.Year = Convert.ToInt32(numUpDownYear.Value);
            addCar.Engine = tbxEngine.Text;
            addCar.FuelType = fuel;
            addCar.Transmission = cbxTransmission.Text;
            addCar.PricePerDay = price;

            return addCar;
        }
        private UpdateCarDto UpdateCarFromForm()
        {
            var updateCar = new UpdateCarDto();


            string fuel = CarManager.WhichFuel(rbtnDiesel.Checked, rbtnGasoline.Checked);

            decimal price = CarManager.CombinePrice(numUpDownPricePerDay.Value, numUpDownPricePerDayAfterComa.Value);

            updateCar.LicensePlateNumber = tbxLicensePlate.Text;
            updateCar.Brand = tbxBrand.Text;
            updateCar.Model = tbxModel.Text;
            updateCar.Color = tbxColor.Text;
            updateCar.Mileage = Convert.ToInt32(numUpDownMileage.Value);
            updateCar.Year = Convert.ToInt32(numUpDownYear.Value);
            updateCar.Engine = tbxEngine.Text;
            updateCar.FuelType = fuel;
            updateCar.Transmission = cbxTransmission.Text;
            updateCar.PricePerDay = price;

            return updateCar;
        }


        private void lblAddData_Click(object sender, EventArgs e){}

        private void label1_Click(object sender, EventArgs e){}

        private void clbFuelType_SelectedIndexChanged(object sender, EventArgs e){}

        private void clbFuelType_ItemCheck(object sender, ItemCheckEventArgs e){}

        private void rbtnDiesel_Click(object sender, EventArgs e){}

        private void checkBox1_CheckedChanged(object sender, EventArgs e){}

        
    }
}
