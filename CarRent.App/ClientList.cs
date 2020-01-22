using CarRent.App;
using CarRent.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using CarRent.Models.Dtos;

namespace Project
{
    public partial class ClientList : Form
    {
        public ClientList()
        {
            InitializeComponent();
        }


        private void ClientList_Load(object sender, EventArgs e)
        {
            lvClientList.View = View.Details;
            lvClientList.GridLines = true;
            lvClientList.FullRowSelect = true;

            lvClientList.Columns.Add("First Name", 150);
            lvClientList.Columns.Add("Last Name", 150);
            lvClientList.Columns.Add("Phone Number", 150);
            lvClientList.Columns.Add("Email", 150);
            lvClientList.Columns.Add("Drivers License Number", 150);
            lvClientList.Columns.Add("PESEL",150);

            var provider = new Dependencies().Load();
            var clientService = provider.GetService<IClientService>();

            foreach (var item in clientService.GetAllClients().ToList())
            {
                if (!item.IsDeleted)
                    lvClientList.Items.Add(ManagerApp.ReadClientData(item));
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var indices = lvClientList.SelectedItems.Count;
            if (indices < 1)
                return;

            var provider = new Dependencies().Load();
            var clientService = provider.GetService<IClientService>();

            int id = Convert.ToInt32(lvClientList.SelectedItems[0].SubItems[0].Text);

            MessageBox.Show(clientService.DeleteClient(id));

            lvClientList.SelectedItems[0].Remove();

        }
    }
}
