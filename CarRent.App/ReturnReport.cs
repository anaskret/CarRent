using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CarRent.Models.Dtos.AddDtos;
using CarRent.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CarRent.App
{
    public partial class ReturnReport : Form
    {
        private readonly int id;
        public ReturnReport(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int numberOfDays = DateTime.DaysInMonth(Convert.ToInt32(numUpDownYear.Value), Convert.ToInt32(numUpDownMonth.Value));
            
            if (numberOfDays < Convert.ToInt32(numUpDownDay.Value))
            {
                MessageBox.Show($"Too many days, this month has: {numberOfDays} days");
                return;
            }

            var provider = new Dependencies().Load();
            var documentService = provider.GetService<IDocumentService>();

            var documentAdd = new AddReturnReportDto();

            var date = new DateTime(Convert.ToInt32(numUpDownYear), Convert.ToInt32(numUpDownMonth), Convert.ToInt32(numUpDownDay));

            documentAdd.DrivenDistance = Convert.ToInt32(numUpDownDrivenDistance.Value);
            documentAdd.IsDamaged = checkbxIsDamaged.Checked;
            documentAdd.ReturnDate = date;

            documentService.AddReturnReport(id, documentAdd);

            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
