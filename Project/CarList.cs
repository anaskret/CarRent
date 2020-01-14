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
            lvCarList.Columns.Add("Is Damaged", 87);
            lvCarList.Columns.Add("Is Away", 87);

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
            MockMenu m = new MockMenu();
            m.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateCar c = new UpdateCar();
            c.Show();
        }
    }
}
