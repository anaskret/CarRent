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

        private bool isUpdate;

        private void ClientList_Load(object sender, EventArgs e)
        {
            _ = new ClientManager(lvClientList);

            ClientManager.CreateListView();
            ClientManager.AddToListView();
            
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var m = new Menu();
            m.Show();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isUpdate = false;
            var c = new AddOrUpdateClient(isUpdate);
            c.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var indices = lvClientList.SelectedItems.Count;
            if (indices < 1)
                return;

            var client = ClientManager.GetItems();

            isUpdate = true;

            var updateClient = new AddOrUpdateClient(client, isUpdate, Convert.ToInt32(lvClientList.SelectedItems[0].SubItems[0].Text));
            updateClient.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lvClientList.Items.Clear();

            ClientManager.AddToListView();
        }
    }
}
