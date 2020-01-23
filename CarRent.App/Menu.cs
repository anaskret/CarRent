using car_fleet;
using Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CarRent.App
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnCarList_Click(object sender, EventArgs e)
        {
            this.Hide();
            CarList wl = new CarList();
            wl.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var cl = new ClientList();
            cl.Show();
        }

        private void btnWorkerList_Click(object sender, EventArgs e)
        {
            this.Hide();
            WorkerList wl = new WorkerList();
            wl.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            var l = new LogIn();
            l.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrdersList ol = new OrdersList();
            ol.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
