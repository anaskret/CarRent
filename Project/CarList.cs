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



        private void CarList_Load_1(object sender, EventArgs e)
        {
            lvCarList.View = View.Details;
            lvCarList.GridLines = true;
            lvCarList.FullRowSelect = true;

            lvCarList.Columns.Add("License plate", 100);
            lvCarList.Columns.Add("Brand", 150);
            lvCarList.Columns.Add("Model", 150);
            lvCarList.Columns.Add("Colour", 100);
            lvCarList.Columns.Add("Mileage", 100);
            lvCarList.Columns.Add("Production year", 100);
            lvCarList.Columns.Add("Engine", 100);
            lvCarList.Columns.Add("Fuel type", 100);
            lvCarList.Columns.Add("Transmission", 100);
            lvCarList.Columns.Add("Price per day", 100);
            lvCarList.Columns.Add("Caretaker", 174);

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

            var car = new Car(licensePlate, brand, model, color, mileage, year, engine, fuelType,  transmission, pricePerDay, caretaker);

            UpdateCar updateCar = new UpdateCar(car);
            updateCar.Show();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var c = new AddCar();
            c.Show();
        }
    }
}
