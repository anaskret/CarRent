using CarRent.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    class ManagerApp
    {
        public static ListViewItem ReadCarData(GetCarDto obj)
        {
            string[] arr = new string[10];
            arr[0] = obj.LicensePlateNumber;
            arr[1] = obj.Brand;
            arr[2] = obj.Model;
            arr[3] = obj.Color;
            arr[4] = obj.Mileage+""; 
            arr[5] = obj.Year+"";
            arr[6] = obj.Engine;
            arr[7] = obj.FuelType;
            arr[8] = obj.Transmission;
            arr[9] = obj.PricePerDay+"";

            var item = new ListViewItem(arr);
            return item;
        }
        public static ListViewItem ReadClientData(GetClientDto obj)
        {
            string[] arr = new string[6];
            arr[0] = obj.FirstName;
            arr[1] = obj.LastName;
            arr[2] = obj.PhoneNumber;
            arr[3] = obj.Email;
            arr[4] = obj.DriversLicenseNumber;
            arr[5] = obj.Pesel;

            var item = new ListViewItem(arr);
            return item;
        }

        public static string WhichFuel(bool diesel, bool gasoline)
        {
            if (diesel == true)
                return "Diesel";
            else if (gasoline == true)
                return "Gasoline";
            else return "Gas";
        }

        public static decimal CombinePrice(decimal integer, decimal decim)
        {
            var afterComa = Convert.ToDouble(decim) * 0.01;
            decimal price = Convert.ToDecimal(Convert.ToDouble(integer)+afterComa);
            return price;
        }
    }
}
