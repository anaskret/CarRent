using CarRent.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using CarRent.Models.Dtos.AddDtos;

namespace CarRent.App
{
    public partial class RepairReport : Form
    {
        private readonly int id;

        public RepairReport(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var provider = new Dependencies().Load();
            var documentService = provider.GetService<IDocumentService>();

            var repairAdd = new AddRepairReportDto();

            repairAdd.Description = rtbxDescription.Text;
            repairAdd.Cost = numUpDownCost.Value;
            repairAdd.Cost = Convert.ToInt32(numUpDownTime.Value);

            if(!repairAdd.Validate())
            {
                MessageBox.Show("Validation error");
                return;
            }

            documentService.AddRepairReport(id, repairAdd);

            this.Hide();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
