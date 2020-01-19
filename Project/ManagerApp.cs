using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    class ManagerApp
    {
        public static ListViewItem ReadData(Car obj)
        {
            string[] arr = new string[11];
            arr[0] = obj.LicensePlate;
            arr[1] = obj.Brand;
            arr[2] = obj.Model;
            arr[3] = obj.Color;
            arr[4] = obj.Mileage+""; 
            arr[5] = obj.ProductionYear+"";
            arr[6] = obj.Engine;
            arr[7] = obj.FuelType;
            arr[8] = obj.Transmission;
            arr[9] = obj.PricePerDay+"";
            arr[10] = obj.Caretaker;

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

        public static double CombinePrice(decimal integer, decimal decim)
        {
            var afterComa = Convert.ToInt32(decim) * 0.01;
            double price = Convert.ToDouble(integer);
            return price;
        }
    }
}
