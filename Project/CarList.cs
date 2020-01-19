using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

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

            lvCarList.Columns.Add("License plate", 100);
            lvCarList.Columns.Add("Brand", 100);
            lvCarList.Columns.Add("Model", 100);
            lvCarList.Columns.Add("Colour", 100);
            lvCarList.Columns.Add("Mileage", 75);
            lvCarList.Columns.Add("Production year", 100);
            lvCarList.Columns.Add("Engine", 100);
            lvCarList.Columns.Add("Fuel type", 100);
            lvCarList.Columns.Add("Transmission", 100);
            lvCarList.Columns.Add("Price per day", 75);
            lvCarList.Columns.Add("Caretaker", 100);

            StreamReader r = new StreamReader("database.json");
            string json = r.ReadToEnd();
            var app = JsonConvert.DeserializeObject<App>(json);
            r.Close();
            r.Dispose();

            var list = app.ListOfCars;

            foreach (var item in list)
            {
                lvCarList.Items.Add(ManagerApp.ReadData(item));
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

            Car car = GetItems(indices);

            isUpdate = true;
            var updateCar = new AddOrUpdateCar(car, isUpdate);
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

            StreamReader r = new StreamReader("database.json");
            string json = r.ReadToEnd();
            var app = JsonConvert.DeserializeObject<App>(json);
            r.Close();
            r.Dispose();

            var list = app.ListOfCars;

            foreach (var item in list)
            {
                lvCarList.Items.Add(ManagerApp.ReadData(item));
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            var indices = lvCarList.SelectedItems.Count;
            if (indices < 1)
                return;

            lvCarList.SelectedItems[0].Remove();
        }

        private void lvCarList_DoubleClick(object sender, EventArgs e)
        {
            var indices = lvCarList.SelectedItems.Count;
            if (indices < 1)
                return;

            Car car = GetItems(indices); 

            isUpdate = true;
            var updateCar = new AddOrUpdateCar(car, isUpdate);
            updateCar.Show();
        }

        private Car GetItems(int indices)
        {
            string licensePlate = lvCarList.SelectedItems[0].SubItems[0].Text;
            string brand = lvCarList.SelectedItems[0].SubItems[1].Text;
            string model = lvCarList.SelectedItems[0].SubItems[2].Text;
            string color = lvCarList.SelectedItems[0].SubItems[3].Text;
            int mileage = Convert.ToInt32(lvCarList.SelectedItems[0].SubItems[4].Text);
            int year = Convert.ToInt32(lvCarList.SelectedItems[0].SubItems[5].Text);
            string engine = lvCarList.SelectedItems[0].SubItems[6].Text;
            string fuelType = lvCarList.SelectedItems[0].SubItems[7].Text;
            string transmission = lvCarList.SelectedItems[0].SubItems[8].Text;
            double pricePerDay = Convert.ToDouble(lvCarList.SelectedItems[0].SubItems[9].Text);
            string caretaker = lvCarList.SelectedItems[0].SubItems[10].Text;

            Car car = new Car(licensePlate, brand, model, color, mileage, year, engine, fuelType, transmission, pricePerDay, caretaker);
            return car;
        }
    }
}
