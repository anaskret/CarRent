using CarRent.App;
using CarRent.Models.Dtos;
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
using System.Linq;

namespace Project
{
    public partial class CarList : Form
    {
        public CarList()
        {
            InitializeComponent();
        }

        public bool isUpdate;

        private void CarList_Load_1(object sender, EventArgs e)
        {
            lvCarList.View = View.Details;
            lvCarList.GridLines = true;
            lvCarList.FullRowSelect = true;

            lvCarList.Columns.Add("ID", 24);
            lvCarList.Columns.Add("License plate", 100);
            lvCarList.Columns.Add("Brand", 100);
            lvCarList.Columns.Add("Model", 100);
            lvCarList.Columns.Add("Color", 100);
            lvCarList.Columns.Add("Mileage", 75);
            lvCarList.Columns.Add("Production year", 100);
            lvCarList.Columns.Add("Engine", 100);
            lvCarList.Columns.Add("Fuel type", 100);
            lvCarList.Columns.Add("Transmission", 100);
            lvCarList.Columns.Add("Price per day", 100);

            var provider = new Dependencies().Load();
            var carService = provider.GetService<ICarService>();
            
            foreach (var item in carService.GetAllCars().ToList())
            {
                if(!item.IsDeleted)
                    lvCarList.Items.Add(ManagerApp.ReadCarData(item));
            }
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var indices = lvCarList.SelectedItems.Count;
            if (indices < 1)
                return;

            var provider = new Dependencies().Load();
            var carService = provider.GetService<ICarService>();

            var car = new UpdateCarDto(); 
            car = GetItems();

            isUpdate = true;
            var updateCar = new AddOrUpdateCar(car, isUpdate, Convert.ToInt32(lvCarList.SelectedItems[0].SubItems[0].Text));
            updateCar.Show();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isUpdate = false;
            var c = new AddOrUpdateCar(isUpdate);
            c.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lvCarList.Items.Clear();

            var provider = new Dependencies().Load();
            var carService = provider.GetService<ICarService>();

            foreach (var item in carService.GetAllCars())
            {
                if (!item.IsDeleted)
                    lvCarList.Items.Add(ManagerApp.ReadCarData(item));
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var provider = new Dependencies().Load();
            var carService = provider.GetService<ICarService>();

            /*if (tbxBrand.TextLength > 0) carFilterString.Add("Brand", tbxBrand.Text);

            if (tbxModel.TextLength > 0) carFilterString.Add("Model", tbxModel.Text);

            if (tbxColor.TextLength > 0) carFilterString.Add("Color", tbxColor.Text);

            if (tbxEngine.TextLength > 0) carFilterString.Add("Engine", tbxEngine.Text);

            if (combobxTransmission.SelectedItem != null) carFilterString.Add("Transmission", combobxTransmission.Text);*/

            /*carFilterString.Add("Brand", "Audi");
            carFilterString.Add("Color", "Black");*/

            Dictionary<string, int[]> carFilterInt = new Dictionary<string, int[]>();
            /* if (numUpDownMinYear.Value != 1950 && numUpDownMaxYear.Value != 2020)
             {
                 int[] year = { Convert.ToInt32(numUpDownMinYear.Value), Convert.ToInt32(numUpDownMaxYear.Value) };
                 carFilterInt.Add("Year", year);
             }
             if (numUpDownMinMileage.Value > 0 && numUpDownMaxMileage.Value < 10000000)
             { 
                 int[] mileage = { Convert.ToInt32(numUpDownMinMileage.Value), Convert.ToInt32(numUpDownMaxMileage.Value) };
                 carFilterInt.Add("Mileage", mileage); 
             }
             if (numUpDownMinPrice.Value > 1 && numUpDownMaxPrice.Value < 500)
             {
                 int[] price = { Convert.ToInt32(numUpDownMinPrice.Value), Convert.ToInt32(numUpDownMaxPrice.Value) };
                 carFilterInt.Add("Price", price);
             }*/

            Dictionary<string, string> carFilterString = new Dictionary<string, string>();

            carFilterString.Add("Brand", "Audi");
            carFilterString.Add("Color", "Black");

            lvCarList.Items.Clear();

            foreach (var item in carService.FilterCars(carFilterString, null))
            {
                if (!item.IsDeleted)
                    lvCarList.Items.Add(ManagerApp.ReadCarData(item));
            }

            tbxBrand.Text = "";
            tbxModel.Text = "";
            tbxColor.Text = "";
            tbxEngine.Text = "";
            combobxTransmission.Text = null;
        }

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            var indices = lvCarList.SelectedItems.Count;
            if (indices < 1)
                return;

            var provider = new Dependencies().Load();
            var carService = provider.GetService<ICarService>();

            int id = Convert.ToInt32(lvCarList.SelectedItems[0].SubItems[0].Text);

            carService.DeleteCar(id);

            lvCarList.SelectedItems[0].Remove();
        }

        private void lvCarList_DoubleClick(object sender, EventArgs e)
        {/*
            var indices = lvCarList.SelectedItems.Count;
            if (indices < 1)
                return;

            CarService car = GetItems(); 

            isUpdate = true;
            var updateCar = new AddOrUpdateCar(car, isUpdate);
            updateCar.Show();*/
        }

        private UpdateCarDto GetItems()
        {
            UpdateCarDto car = new UpdateCarDto();
            car.LicensePlateNumber = lvCarList.SelectedItems[0].SubItems[1].Text;
            car.Brand = lvCarList.SelectedItems[0].SubItems[2].Text;
            car.Model = lvCarList.SelectedItems[0].SubItems[3].Text;
            car.Color = lvCarList.SelectedItems[0].SubItems[4].Text;
            car.Mileage = Convert.ToInt32(lvCarList.SelectedItems[0].SubItems[5].Text);
            car.Year = Convert.ToInt32(lvCarList.SelectedItems[0].SubItems[6].Text);
            car.Engine = lvCarList.SelectedItems[0].SubItems[7].Text;
            car.FuelType = lvCarList.SelectedItems[0].SubItems[8].Text;
            car.Transmission = lvCarList.SelectedItems[0].SubItems[9].Text;
            car.PricePerDay = Convert.ToDecimal(lvCarList.SelectedItems[0].SubItems[10].Text);

            return car;
        }
    }
}
