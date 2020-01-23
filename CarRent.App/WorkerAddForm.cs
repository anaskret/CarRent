using CarRent.App;
using CarRent.Models.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace car_fleet
{
    public partial class WorkerAddForm : Form
    {
        public WorkerAddForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void WorkerAddForm_Load(object sender, EventArgs e)
        {
            if (WorkerManager.isEditWorker)
            {
                GetWorkerDto worker = WorkerManager.CurrentWorker;
                label1.Text = $"EDIT WORKER {worker.Id}";
                tbFirstName.Text = worker.FirstName;
                tbLastName.Text = worker.LastName;
                tbPhone.Text = worker.PhoneNumber;
                tbSalary.Text = worker.Salary+"";
                button1.Text = "EDIT";
            }
            else
            {
                label1.Text = "ADD WORKER";
                tbFirstName.Clear();
                tbLastName.Clear();
                tbPhone.Clear();
                tbSalary.Clear();
                button1.Text = "ADD";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(WorkerManager.CheckWorker(tbFirstName.Text,tbLastName.Text,tbPhone.Text,tbSalary.Text))
            {
                if (WorkerManager.isEditWorker)
                {
                    WorkerManager.EditWorker(tbFirstName.Text, tbLastName.Text, tbPhone.Text, Convert.ToDecimal(tbSalary.Text));
                }
                else
                {
                    WorkerManager.AddNewWorker(tbFirstName.Text, tbLastName.Text, tbPhone.Text, Convert.ToDecimal(tbSalary.Text));

                }
             
                 var workerList = new WorkerList();
                  this.Hide();
                workerList.Show();
            }
           
        }

        private void tbPhone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
