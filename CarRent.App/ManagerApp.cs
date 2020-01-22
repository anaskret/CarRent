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
            string[] arr = new string[11];
            arr[0] = obj.Id+"";
            arr[1] = obj.LicensePlateNumber;
            arr[2] = obj.Brand;
            arr[3] = obj.Model;
            arr[4] = obj.Color;
            arr[5] = obj.Mileage+""; 
            arr[6] = obj.Year+"";
            arr[7] = obj.Engine;
            arr[8] = obj.FuelType;
            arr[9] = obj.Transmission;
            arr[10] = obj.PricePerDay+"";

            var item = new ListViewItem(arr);
            return item;
        }
        public static ListViewItem ReadClientData(GetClientDto obj)
        {
            string[] arr = new string[7];
            arr[0] = obj.Id+"";
            arr[1] = obj.FirstName;
            arr[2] = obj.LastName;
            arr[3] = obj.PhoneNumber;
            arr[4] = obj.Email;
            arr[5] = obj.DriversLicenseNumber;
            arr[6] = obj.Pesel;
            
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
