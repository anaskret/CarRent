﻿using CarRent.DataAccess;
using CarRent.Models.Entities;
using CarRent.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRent.Repositories
{    

    public class CoordinatorRepository : ICoordinatorRepository
    {
        private readonly CarRentDbContext _db;
        public CoordinatorRepository(CarRentDbContext db)
        {
            _db = db;
        }

        public int Add(Coordinator coordinator)
        {
            _db.Coordinators.Add(coordinator);
            _db.SaveChanges();

            return coordinator.Id;
        }

        public Coordinator Get(int id)
        {
            try
            {
                return _db.Coordinators.First(c => c.Id == id);
            }
            catch(InvalidOperationException e)
            {
                return null;
            }
            
            // catch invalid operation exception
        }

        public bool ValidateLogin(string login, string password)
        {
            var coordinator = _db.Coordinators.First(c => c.Login == login);
            if (coordinator != null)
            {
                if (coordinator.Password == password) { return true; }              
            }
            return false;
        }
    }
}
