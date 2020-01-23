using CarRent.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

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
            string[] arr = new string[7];
            arr[0] = obj.Id + "";
            arr[1] = obj.FirstName;
            arr[2] = obj.LastName;
            arr[3] = obj.PhoneNumber;
            arr[4] = obj.Email;
            arr[5] = obj.DriversLicenseNumber;
            arr[6] = obj.Pesel;

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
            LvClientList.Columns.Add("Drivers License Number", 150);
            LvClientList.Columns.Add("PESEL", 150);
        }
    }
}
