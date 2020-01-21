﻿using CarRent.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarRent.DataAccess
{
    public class CarRentDbContext : DbContext
    {
        public CarRentDbContext(DbContextOptions<CarRentDbContext> options)
            : base(options)
        { }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Coordinator> Coordinators { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ReturnReport> ReturnReports { get; set; }
        public DbSet<RepairReport> RepairReports { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
                       
            base.OnModelCreating(builder);

            builder.Entity<Worker>()
                .HasOne(w => w.Car)
                .WithOne(c => c.Worker)
                .HasForeignKey<Car>(c => c.WorkerId);

            builder.Entity<Worker>()
                .HasOne(w => w.Coordinator)
                .WithMany(c => c.Workers)
                .HasForeignKey(w => w.CoordinatorId);

            builder.Entity<Order>()
                .HasOne(o => o.ReturnReport)
                .WithOne(rr => rr.Order)
                .HasForeignKey<ReturnReport>(rr => rr.OrderId);

            builder.Entity<Order>()
                .HasOne(o => o.RepairReport)
                .WithOne(rr => rr.Order)
                .HasForeignKey<RepairReport>(rr => rr.OrderId);
        }
    }
}
