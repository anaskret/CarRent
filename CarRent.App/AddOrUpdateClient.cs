using CarRent.Models.Dtos;
using CarRent.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace CarRent.App
{
    public partial class AddOrUpdateClient : Form
    {
        private readonly UpdateClientDto client;
        private readonly bool isUpdate;
        private readonly int id;

        public AddOrUpdateClient(bool isUpdate)
        {
            this.isUpdate = isUpdate;
            InitializeComponent();
        }

        public AddOrUpdateClient(UpdateClientDto client, bool isUpdate, int id)
        {
            InitializeComponent();
            this.client = client;
            this.isUpdate = isUpdate;
            this.id = id;
        }

        private void lblPesel_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var provider = new Dependencies().Load();
            IClientService clientService = provider.GetService<IClientService>();

            if(isUpdate)
            {
                var clientUpdate = new UpdateClientDto {
                    FirstName = tbxFirstName.Text,
                    LastName = tbxLastName.Text,
                    PhoneNumber = tbxPhoneNumber.Text,
                    Email = tbxEmail.Text,
                    DriversLicenseNumber = tbxDriversLicenseNumber.Text,
                    IdNumber = tbxIdNumber.Text,
                    Pesel = tbxPesel.Text
                };
                if(!clientUpdate.Validate())
                {
                    MessageBox.Show("Validation error");
                    return;
                }
                clientService.UpdateClient(id, clientUpdate);

                this.Hide();
            }
            else
            {
                var clientAdd = new AddClientDto
                {
                    FirstName = tbxFirstName.Text,
                    LastName = tbxLastName.Text,
                    PhoneNumber = tbxPhoneNumber.Text,
                    Email = tbxEmail.Text,
                    DriversLicenseNumber = tbxDriversLicenseNumber.Text,
                    IdNumber = tbxIdNumber.Text,
                    Pesel = tbxPesel.Text
                };
                if (!clientAdd.Validate())
                {
                    MessageBox.Show("Validation error");
                    return;
                }
                clientService.AddClient(clientAdd);

                this.Hide();
            }
        }

        private void AddOrUpdateClient_Load(object sender, EventArgs e)
        {
            if(isUpdate == true)
            {
                tbxFirstName.Text = client.FirstName;
                tbxLastName.Text = client.LastName;
                tbxDriversLicenseNumber.Text = client.DriversLicenseNumber;
                tbxEmail.Text = client.Email;
                tbxIdNumber.Text = client.IdNumber;
                tbxPesel.Text = client.Pesel;
                tbxPhoneNumber.Text = client.PhoneNumber;
            }
        }
    }
}
