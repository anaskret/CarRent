using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    public class Car
    {
        public Car(string licensePlate, string brand, string model,
            string colour, string mileage, string productionYear, 
            string engine, string fuelType, string transmission,
            string pricePerDay, string isDamaged, string isAway)
        {
            LicensePlate = licensePlate;
            Brand = brand;
            Model = model;
            Colour = colour;
            Mileage = mileage;
            ProductionYear = productionYear;
            Engine = engine;
            FuelType = fuelType;
            Transmission = transmission;
            PricePerDay = pricePerDay;
            IsDamaged = isDamaged;
            IsAway = isAway;
        }

        public string LicensePlate { get; set; }
        public string Brand { get; set; }
        public string Model{ get; set; }
        public string Colour{ get; set; }
        public string Mileage { get; set; }
        public string ProductionYear { get; set; }
        public string Engine{ get; set; }
        public string FuelType{ get; set; }
        public string Transmission { get; set; }
        public string PricePerDay { get; set; }
        public string IsDamaged { get; set; }
        public string IsAway { get; set; }
    }
}
