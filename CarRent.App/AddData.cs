using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CarRent.Models.Dtos;
using CarRent.Models.Dtos.AddDtos;
using CarRent.Services;
using CarRent.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;



namespace CarRent.App
{
    public class AddData
    {
        public static void SeedData()
        {
            var provider = new Dependencies().Load();
            
            var coordinatorService = provider.GetService<ICoordinatorService>();

            if (coordinatorService.GetCoordinator(1) == null)
            {
               var coordinator = new AddCoordinatorDto
                {
                    Login = "admin",
                    Password = "admin",
                    FirstName = "admin",
                    LastName = "adminski",
                    Email = "admin@admin.com",
                    PhoneNumber = "999999999"
                };

                coordinatorService.Add(coordinator);
            }

            var carService = provider.GetService<ICarService>();

            if (carService.GetAllCars().ToList().Count == 0)
            {
                var car = new AddCarDto
                {
                    LicensePlateNumber = "PO12QDE",
                    Brand = "Audi",
                    Model = "A5",
                    Color = "Black",
                    Engine = "V8",
                    FuelType = "Gasoline",
                    Mileage = 35000,
                    Year = 2015,
                    Transmission = "Automatic",
                    PricePerDay = 80
                };

                carService.AddCar(car);

                car.LicensePlateNumber = "PWL12341";
                car.Brand = "Mazda";
                car.Model = "CX#";
                car.Color = "Grey";
                car.Engine = "10A";
                car.FuelType = "Gasoline";
                car.Mileage = 1000;
                car.Year = 2018;
                car.Transmission = "Automatic";
                car.PricePerDay = 100;

                carService.AddCar(car);
                car.LicensePlateNumber = "PGOSND13";
                car.Brand = "Audi";
                car.Model = "A4";
                car.Color = "Yellow";
                car.Engine = "V4";
                car.FuelType = "Gas";
                car.Mileage = 94000;
                car.Year = 2000;
                car.Transmission = "Manual";
                car.PricePerDay = 30;

                carService.AddCar(car);
                car.LicensePlateNumber = "PO1SSDE";
                car.Brand = "Toyota";
                car.Model = "Yaris";
                car.Color = "Red";
                car.Engine = "2C";
                car.FuelType = "Diesel";
                car.Mileage = 10000;
                car.Year = 2007;
                car.Transmission = "Manual";
                car.PricePerDay = 40;

                carService.AddCar(car);
                car.LicensePlateNumber = "POPES67";
                car.Brand = "Kia";
                car.Model = "Rio";
                car.Color = "Red";
                car.Engine = "5T";
                car.FuelType = "Gas";
                car.Mileage = 100000;
                car.Year = 2012;
                car.Transmission = "Manual";
                car.PricePerDay = 50;

                carService.AddCar(car);
                car.LicensePlateNumber = "PO6WM23";
                car.Brand = "Mercedes";
                car.Model = "A Klasa";
                car.Color = "Silver";
                car.Engine = "V10";
                car.FuelType = "Gasoline";
                car.Mileage = 0;
                car.Year = 2019;
                car.Transmission = "Automatic";
                car.PricePerDay = 200;

                carService.AddCar(car);
                car.LicensePlateNumber = "POSPW42";
                car.Brand = "Audi";
                car.Model = "A5";
                car.Color = "Green";
                car.Engine = "V8";
                car.FuelType = "Gasoline";
                car.Mileage = 20000;
                car.Year = 2016;
                car.Transmission = "Automatic";
                car.PricePerDay = 70;

                carService.AddCar(car);
                car.LicensePlateNumber = "PODW293";
                car.Brand = "Mercedes";
                car.Model = "GLE";
                car.Color = "Silver";
                car.Engine = "V8";
                car.FuelType = "Gasoline";
                car.Mileage = 10000;
                car.Year = 2010;
                car.Transmission = "Manual";
                car.PricePerDay = 55;

                carService.AddCar(car);
            }



            var clientService = provider.GetService<IClientService>();
            

             if (clientService.GetAllClients().ToList().Count == 0)
               {
                   var client = new AddClientDto
                   {
                       FirstName = "Angelika",
                       LastName = "Maciejewska",
                       PhoneNumber = "53 967 04 00",
                       Email = "AngelikaMaciejewska@armyspy.com",
                       DriversLicenseNumber = "45809765",
                       IdNumber = "824997591",
                       Pesel = "93070222544"
                   };

                   clientService.AddClient(client);

                    client.FirstName = "Karol";
                    client.LastName = "Jablonski";
                    client.PhoneNumber = "727315307";
                    client.Email = "KarolJablonski@armyspy.com";
                    client.DriversLicenseNumber = "331304196";
                    client.IdNumber = "825480638";
                    client.Pesel = "62020367914";

                    clientService.AddClient(client);

                    client.FirstName = "Elzbieta";
                    client.LastName = "Szczepanska";
                    client.PhoneNumber = "786815254";
                    client.Email = "ElzbietaSzczepanska@teleworm.us";
                    client.DriversLicenseNumber = "73630362";
                    client.IdNumber = "831290266";
                    client.Pesel = "93070222544";

                    clientService.AddClient(client);
                    client.FirstName = "Angelika";
                    client.LastName = "Maciejewska";
                    client.PhoneNumber = "539670400";
                    client.Email = "AngelikaMaciejewska@armyspy.com";
                    client.DriversLicenseNumber = "45809765";
                    client.IdNumber = "824997591";
                    client.Pesel = "49011918485";

                    clientService.AddClient(client);

                    client.FirstName = "Wladyslawa";
                    client.LastName = "MacMichalskaiejewska";
                    client.PhoneNumber = "512863256";
                    client.Email = "WladyslawaMichalska@armyspy.com";
                    client.DriversLicenseNumber = "798628527";
                    client.IdNumber = "822171567";
                    client.Pesel = "65072312901";

                    clientService.AddClient(client);

                    client.FirstName = "Basia";
                    client.LastName = "Majewska";
                    client.PhoneNumber = "796640972";
                    client.Email = "BasiaMajewska@teleworm.us";
                    client.DriversLicenseNumber = "713825975";
                    client.IdNumber = "182399162";
                    client.Pesel = "79080548849";

                    clientService.AddClient(client);

                    client.FirstName = "Antoni";
                    client.LastName = "Jasinski";
                    client.PhoneNumber = "539670400";
                    client.Email = "AntoniJasinski@jourrapide.com";
                    client.DriversLicenseNumber = "461293795";
                    client.IdNumber = "159124524";
                    client.Pesel = "42081913792";

                   clientService.AddClient(client);
               }
   
            var workerService = provider.GetService<IWorkerService>();
            if (workerService.GetAllWorkers().ToList().Count == 0)
            {
                var worker = new AddWorkerDto
                {
                    FirstName = "Iwona",
                    LastName = "Grabowska",
                    PhoneNumber = "782428901",
                    Email = "iwonagrabowska@carrent.com",
                    Salary = 3500
                };

                workerService.AddWorker(1, worker);

                worker.FirstName = "Krystiana";
                worker.LastName = "Nowakowska";
                worker.PhoneNumber = "603705958";
                worker.Email = "krystiananowakowska@carrent.com";
                worker.Salary = 200;

                workerService.AddWorker(1, worker);

                worker.FirstName = "Leokadia";
                worker.LastName = "Grabowska";
                worker.PhoneNumber = "729191349";
                worker.Email = "leokadiagrabowska@carrent.com";
                worker.Salary = 4000;

                workerService.AddWorker(1, worker);

                worker.FirstName = "Roscislawa";
                worker.LastName = "Kucharska";
                worker.PhoneNumber = "784646893";
                worker.Email = "roscislawakucharsa@carrent.com";
                worker.Salary = 3500;

                workerService.AddWorker(1, worker);

                worker.FirstName = "Frydrych";
                worker.LastName = "Kowalczyk";
                worker.PhoneNumber = "786549293";
                worker.Email = "frydrychkowalczyk@carrent.com";
                worker.Salary = 3400;

                workerService.AddWorker(1, worker);

                worker.FirstName = "Bonifacy";
                worker.LastName = "Olszewski";
                worker.PhoneNumber = "667174534";
                worker.Email = "bonifacyolszewski@carrent.com";
                worker.Salary = 3200;

                workerService.AddWorker(1, worker);

                worker.FirstName = "Gustaw";
                worker.LastName = "Kowalski";
                worker.PhoneNumber = "533447612";
                worker.Email = "gustawkowalski@carrent.com";
                worker.Salary = 4200;

                workerService.AddWorker(1, worker);

            }

        }
    }
}
