using CarRent.App;
using CarRent.Models.Dtos;
using CarRent.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace Project
{
    class CarManager
    {
        
       
        public CarManager()
        {
        }

        public CarManager(ListView listView)
        {
            LvCarList = listView;
        }

        public static ListView LvCarList { get; private set; }

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
        
        

        public static UpdateCarDto GetItems()
        {
            UpdateCarDto car = new UpdateCarDto();
            car.LicensePlateNumber = LvCarList.SelectedItems[0].SubItems[1].Text;
            car.Brand = LvCarList.SelectedItems[0].SubItems[2].Text;
            car.Model = LvCarList.SelectedItems[0].SubItems[3].Text;
            car.Color = LvCarList.SelectedItems[0].SubItems[4].Text;
            car.Mileage = Convert.ToInt32(LvCarList.SelectedItems[0].SubItems[5].Text);
            car.Year = Convert.ToInt32(LvCarList.SelectedItems[0].SubItems[6].Text);
            car.Engine = LvCarList.SelectedItems[0].SubItems[7].Text;
            car.FuelType = LvCarList.SelectedItems[0].SubItems[8].Text;
            car.Transmission = LvCarList.SelectedItems[0].SubItems[9].Text;
            car.PricePerDay = Convert.ToDecimal(LvCarList.SelectedItems[0].SubItems[10].Text);

            return car;
        }

        public static void CreateListView()
        {
            LvCarList.View = View.Details;
            LvCarList.GridLines = true;
            LvCarList.FullRowSelect = true;
            
            LvCarList.Columns.Add("ID", 24);
            LvCarList.Columns.Add("License plate", 100);
            LvCarList.Columns.Add("Brand", 100);
            LvCarList.Columns.Add("Model", 100);
            LvCarList.Columns.Add("Color", 100);
            LvCarList.Columns.Add("Mileage", 75);
            LvCarList.Columns.Add("Production year", 100);
            LvCarList.Columns.Add("Engine", 100);
            LvCarList.Columns.Add("Fuel type", 100);
            LvCarList.Columns.Add("Transmission", 100);
            LvCarList.Columns.Add("Price per day", 100);
        }

        public static void AddToListView()
        {
            var provider = new Dependencies().Load();
            var carService = provider.GetService<ICarService>();

            foreach (var item in carService.GetAllCars().ToList())
            {
                if (!item.IsDeleted)
                    LvCarList.Items.Add(ReadCarData(item));
            }
        }

        public static Dictionary<string, string> CarFilterString(string brand, string model, string color, string engine, string transmission)
        {
            var carFilterString = new Dictionary<string, string>();

            if (brand.Length > 0) 
                carFilterString.Add("Brand", brand);

            if (model.Length > 0) 
                carFilterString.Add("Model", model);

            if (color.Length > 0) 
                carFilterString.Add("Color", color);

            if (engine.Length > 0)
                carFilterString.Add("Engine", engine);

            if (transmission != "") 
                carFilterString.Add("Transmission", transmission);

            return carFilterString;
        }

        public static Dictionary<string, int[]> CarFilterInt(decimal minYear, decimal maxYear, decimal minMileage, decimal maxMileage, decimal minPrice, decimal maxPrice)
        {
            var carFilterInt = new Dictionary<string, int[]>();

            if (minYear > 1950 || maxYear < 2020)
            {
                int[] year = { Convert.ToInt32(minYear), Convert.ToInt32(maxYear) };
                carFilterInt.Add("Year", year);
            }
            if (minMileage > 0 || maxMileage < 10000000)
            {
                int[] mileage = { Convert.ToInt32(minMileage), Convert.ToInt32(maxMileage) };
                carFilterInt.Add("Mileage", mileage);
            }
            if (minPrice > 1 || maxPrice< 500)
            {
                int[] price = { Convert.ToInt32(minPrice), Convert.ToInt32(maxPrice) };
                carFilterInt.Add("Price", price);
            }

            return carFilterInt;
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
            decimal price = Convert.ToDecimal(Convert.ToDouble(integer) + afterComa);
            return price;
        }

    }
}
