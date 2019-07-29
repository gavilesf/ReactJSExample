using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Models
{
    public class CarRentalContext: DbContext
    {
        public CarRentalContext(DbContextOptions<CarRentalContext> options) :base(options){
            
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

    }
}
