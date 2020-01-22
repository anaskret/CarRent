using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.RegularExpressions;

namespace CarRent.Models.Dtos
{
    public class UpdateCarDto
    {
        public string LicensePlateNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Engine { get; set; }
        public int Year { get; set; }
        public string Transmission { get; set; }
        public string FuelType { get; set; }
        public string Color { get; set; }
        public Decimal PricePerDay { get; set; }
        public int Mileage { get; set; }

        public bool ValidateCarInput(UpdateCarDto car)
        {
            Regex alphanumeric = new Regex("^[a-zA-Z0-9]*$");
            if (!alphanumeric.IsMatch(car.LicensePlateNumber)
                || !alphanumeric.IsMatch(car.Brand)
                || !alphanumeric.IsMatch(car.Model)
                || !alphanumeric.IsMatch(car.Engine)
                || !alphanumeric.IsMatch(car.Color))
                return false;

            if (car.LicensePlateNumber.Length < 6 || car.Brand.Length < 1
                || car.Model.Length < 1 || car.Engine.Length < 1
                || car.Transmission == "" || car.Color.Length < 3)
                return false;

            return true;
        }
    }
}
