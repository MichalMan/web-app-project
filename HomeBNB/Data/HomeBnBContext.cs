using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HomeBnB.Models;

namespace HomeBnB.Models
{
    public class HomeBnBContext : DbContext
    {
        public HomeBnBContext (DbContextOptions<HomeBnBContext> options)
            : base(options)
        {
        }

        public DbSet<HomeBnB.Models.Apartment> Apartment { get; set; }

        public DbSet<HomeBnB.Models.LandLord> LandLord { get; set; }

        public DbSet<HomeBnB.Models.Review> Review { get; set; }

        public DbSet<HomeBnB.Models.Renter> Renter { get; set; }
       
    }
}
