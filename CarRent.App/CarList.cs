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
            CarManager carManager = new CarManager(lvCarList);

            CarManager.CreateListView();
            CarManager.AddToListView();
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

            UpdateCarDto car = CarManager.GetItems();

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

            CarManager.AddToListView();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var provider = new Dependencies().Load();
            var carService = provider.GetService<ICarService>();

            Dictionary<string, string> carFilterString = CarManager.CarFilterString(tbxBrand.Text, tbxModel.Text, tbxColor.Text, tbxEngine.Text, combobxTransmission.Text);

            Dictionary<string, int[]> carFilterInt = CarManager.CarFilterInt(numUpDownMinYear.Value, numUpDownMaxYear.Value, numUpDownMinMileage.Value, numUpDownMaxMileage.Value, 
                numUpDownMinPrice.Value, numUpDownMaxPrice.Value);

            if (carFilterString.Count == 0 && carFilterInt.Count == 0)
                return;

            lvCarList.Items.Clear();

            foreach (var item in carService.FilterCars(carFilterString, carFilterInt, null))
            {
                if (!item.IsDeleted)
                    lvCarList.Items.Add(CarManager.ReadCarData(item));
            }

            tbxBrand.Text = "";
            tbxModel.Text = "";
            tbxColor.Text = "";
            tbxEngine.Text = "";
            combobxTransmission.Text = null;
            numUpDownMinYear.Value = 1950;
            numUpDownMaxYear.Value = 2020;
            numUpDownMinMileage.Value = 0;
            numUpDownMaxMileage.Value = 10000000;
            numUpDownMinPrice.Value = 1;
            numUpDownMaxPrice.Value = 500;

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
        {
            var indices = lvCarList.SelectedItems.Count;
            if (indices < 1)
                return;

            UpdateCarDto car = CarManager.GetItems();

            isUpdate = true;
            var updateCar = new AddOrUpdateCar(car, isUpdate, Convert.ToInt32(lvCarList.SelectedItems[0].SubItems[0].Text));
            updateCar.Show();
        }

        
    }
}
