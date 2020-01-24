using CarRent.Models.Dtos;
using CarRent.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace CarRent.App
{
    class ClientManager
    {

        public ClientManager(ListView listView)
        {
            LvClientList = listView;
        }

        public static ListView LvClientList { get; private set; }


        public static ListViewItem ReadClientData(GetClientDto obj)
        {
            string[] arr = new string[8];
            arr[0] = obj.Id + "";
            arr[1] = obj.FirstName;
            arr[2] = obj.LastName;
            arr[3] = obj.PhoneNumber;
            arr[4] = obj.Email;
            arr[5] = obj.IdNumber;
            arr[6] = obj.DriversLicenseNumber;
            arr[7] = obj.Pesel;

            var item = new ListViewItem(arr);
            return item;
        }

        public static void CreateListView()
        {
            LvClientList.View = View.Details;
            LvClientList.GridLines = true;
            LvClientList.FullRowSelect = true;
            
            LvClientList.Columns.Add("ID", 24);
            LvClientList.Columns.Add("First Name", 150);
            LvClientList.Columns.Add("Last Name", 150);
            LvClientList.Columns.Add("Phone Number", 150);
            LvClientList.Columns.Add("Email", 150);
            LvClientList.Columns.Add("ID Number", 150);
            LvClientList.Columns.Add("Drivers License Number", 150);
            LvClientList.Columns.Add("PESEL", 150);
        }

        public static void AddToListView()
        {
            var provider = new Dependencies().Load();
            var clientService = provider.GetService<IClientService>();

            foreach (var item in clientService.GetAllClients().ToList())
            {
                if (!item.IsDeleted)
                    LvClientList.Items.Add(ReadClientData(item));
            }
        }

        public static UpdateClientDto GetItems()
        {
            var client = new UpdateClientDto
            {
                FirstName = LvClientList.SelectedItems[0].SubItems[1].Text,
                LastName = LvClientList.SelectedItems[0].SubItems[2].Text,
                PhoneNumber = LvClientList.SelectedItems[0].SubItems[3].Text,
                Email = LvClientList.SelectedItems[0].SubItems[4].Text,
                IdNumber = LvClientList.SelectedItems[0].SubItems[5].Text,
                DriversLicenseNumber = LvClientList.SelectedItems[0].SubItems[6].Text,
                Pesel = LvClientList.SelectedItems[0].SubItems[7].Text,
            };

            return client;
        }
    }
}
