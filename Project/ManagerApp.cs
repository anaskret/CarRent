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
            string[] arr = new string[12];
            arr[0] = obj.LicensePlate;
            arr[1] = obj.Brand;
            arr[2] = obj.Model;
            arr[3] = obj.Colour;
            arr[4] = obj.Mileage;
            arr[5] = obj.ProductionYear;
            arr[6] = obj.Engine;
            arr[7] = obj.FuelType;
            arr[8] = obj.Transmission;
            arr[9] = obj.PricePerDay;
            arr[10] = obj.IsDamaged;
            arr[11] = obj.IsAway;
            var item = new ListViewItem(arr);
            return item;
        }
        
        public static Car AddData(Car obj)
        {
            return obj;
        }
    }
}
