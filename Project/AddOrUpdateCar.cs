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

            string fuel = ManagerApp.WhichFuel(rbtnDiesel.Checked, rbtnGasoline.Checked);

            decimal price = ManagerApp.CombinePrice(numUpDownPricePerDay.Value, numUpDownPricePerDayAfterComa.Value);

            CarService car = new CarService(tbLicensePlate.Text, tbBrand.Text, tbModel.Text, tbColor.Text, Convert.ToInt32(numUpDownMileage.Value), Convert.ToInt32(numUpDownYear.Value),
                tbEngine.Text, fuel, cbxTransmission.Text, price);



            dynamic addCar = new JObject();
            addCar.licensePlate = tbLicensePlate.Text;
            addCar.brand = tbBrand.Text;
            addCar.model= tbModel.Text;
            addCar.color= tbColor.Text;
            addCar.mileage= Convert.ToInt32(numUpDownMileage.Value);
            addCar.productionYear= Convert.ToInt32(numUpDownYear.Value);
            addCar.engine = tbEngine.Text;
            addCar.fuelType= fuel;
            addCar.transmission= cbxTransmission.Text;
            addCar.pricePerDay = price;
            addCar.caretaker = cbxCaretaker.Text;

            JObject rss = JObject.Parse(File.ReadAllText("database.json"));
            JArray listOfCars = (JArray)rss["listOfCars"];
            listOfCars.Add(addCar);

            File.WriteAllText("database.json", rss.ToString());
            MessageBox.Show($"{File.ReadAllText("database.json")}");
            this.Hide();
        }


        private void lblAddData_Click(object sender, EventArgs e){}

        private void label1_Click(object sender, EventArgs e){}

        private void clbFuelType_SelectedIndexChanged(object sender, EventArgs e){}

        private void clbFuelType_ItemCheck(object sender, ItemCheckEventArgs e){}

        private void rbtnDiesel_Click(object sender, EventArgs e){}

        private void checkBox1_CheckedChanged(object sender, EventArgs e){}

        
    }
}
