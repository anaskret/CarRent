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
    public partial class WorkerList : Form
    {
        public WorkerList()
        {
            InitializeComponent();
        }

        private void WorkerList_Load(object sender, EventArgs e)
        {
            WorkerManager manager = new WorkerManager(lvWorkerList);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbRegion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbRegion_SelectionChangeCommitted(object sender, EventArgs e)
        {

          
        }

        private void button4_Click(object sender, EventArgs e)
        {
             WorkerManager.isEditWorker = false;
            var workerAdd = new WorkerAddForm();
            workerAdd.Location = this.Location;
            workerAdd.StartPosition = FormStartPosition.Manual;
            workerAdd.FormClosing += delegate { this.Show(); };
            workerAdd.Show();
            this.Hide();
        }

        private void lvWorkerList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string id = lvWorkerList.SelectedItems[0].SubItems[0].Text;

            WorkerManager.FindWorker(Convert.ToInt32(id));

            var workerAdd = new WorkerAddForm();
            workerAdd.Location = this.Location;
            workerAdd.StartPosition = FormStartPosition.Manual;
            workerAdd.FormClosing += delegate { this.Show(); };
            workerAdd.Show();
            this.Hide();
        }

        private void lvWorkerList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            WorkerManager.DeleteWorker();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var m = new Menu();
            m.Show();
        }
    }
}
