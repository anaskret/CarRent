using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    public class CarService
    {
        public CarService(string licensePlate, string brand, string model,
            string color, int mileage, int productionYear, 
            string engine, string fuelType, string transmission,
            decimal pricePerDay)
        {
            LicensePlate = licensePlate;
            Brand = brand;
            Model = model;
            Color = color;
            Mileage = mileage;
            ProductionYear = productionYear;
            Engine = engine;
            FuelType = fuelType;
            Transmission = transmission;
            PricePerDay = pricePerDay;
        }


        public string LicensePlate { get; set; }
        public string Brand { get; set; }
        public string Model{ get; set; }
        public string Color{ get; set; }
        public int Mileage { get; set; }
        public int ProductionYear { get; set; }
        public string Engine{ get; set; }
        public string FuelType{ get; set; }
        public string Transmission { get; set; }
        public decimal PricePerDay { get; set; }
    }
}
