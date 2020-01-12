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

        public string LicensePlate { get; private set; }
        public string Brand { get; private set; }
        public string Model{ get; private set; }
        public string Colour{ get; private set; }
        public string Mileage { get; private set; }
        public string ProductionYear { get; private set; }
        public string Engine{ get; private set; }
        public string FuelType{ get; private set; }
        public string Transmission { get; private set; }
        public string PricePerDay { get; private set; }
        public string IsDamaged { get; private set; }
        public string IsAway { get; private set; }
    }
}
