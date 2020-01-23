using CarRent.App;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace car_fleet
{
    public partial class OrdersList : Form
    {
        public OrdersList()
        {
            InitializeComponent();
        }

        private void OrdesList_Load(object sender, EventArgs e)
        {
            OrderManager manager = new OrderManager(lvOrderList);
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            OderAddForms addOrder = new OderAddForms();
            addOrder.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var indices = lvOrderList.SelectedItems.Count;
            if (indices < 1)
                return;

            int id = Convert.ToInt32(lvOrderList.SelectedItems[0].SubItems[0].Text);

            var rr = new ReturnReport(id);
            rr.Show();
        }

        private void btnDelivered_Click(object sender, EventArgs e)
        {
            var indices = lvOrderList.SelectedItems.Count;
            if (indices < 1)
                return;

            int id = Convert.ToInt32(lvOrderList.SelectedItems[0].SubItems[0].Text);

            var rr = new RepairReport(id);
            rr.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var m = new Menu();
            m.Show();
        }

        private void lvOrderList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
