using Lab3MVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Lab3MVC.Data
{
    public class ParkingContext : DbContext
    {

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Pass> Passes { get; set; }
        public DbSet<ParkingSpot> ParkingSpots { get; set; }

        public DbSet<Reservation> Reservations { get; set; }

    }
}
