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
            var clientManager = new ClientManager(lvClientList);
            ClientManager.CreateListView();

            var provider = new Dependencies().Load();
            var clientService = provider.GetService<IClientService>();

            foreach (var item in clientService.GetAllClients().ToList())
            {
                if (!item.IsDeleted)
                    lvClientList.Items.Add(ClientManager.ReadClientData(item));
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
