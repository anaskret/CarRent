using car_fleet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CarRent.App
{
    public partial class OderAddForms : Form
    {
        public OderAddForms()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OderAddForms_Load(object sender, EventArgs e)
        {
            OrderManager.LoadCarToComboBox(cbCars);
            OrderManager.LoadWorkerToComboBox(cbWorkers);
            OrderManager.LoadClientToComboBox(cbClients);
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            int rentalTime = Convert.ToInt32(nudRentalTime.Value);
            string deliveryPlace = tbPlace.Text;
            var carId = (int)cbCars.SelectedValue;
            DateTime orderTime = dtpOrder.Value;
            int workerId = (int)cbWorkers.SelectedValue;
            int clientId = (int)cbClients.SelectedValue;
             
          OrderManager.AddNewOrder(workerId,carId,clientId,rentalTime,deliveryPlace,orderTime);
            MessageBox.Show("ADD ORDER SUCCESED!");
        }
    }
}
