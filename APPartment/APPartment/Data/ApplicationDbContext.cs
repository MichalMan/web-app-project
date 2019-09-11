using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using APPartment.Models;
using Appartment.Models;

namespace APPartment.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<APPartment.Models.Apartment> Apartment { get; set; }
        public DbSet<Appartment.Models.LandLord> LandLord { get; set; }
        public DbSet<Appartment.Models.Renter> Renter { get; set; }
        public DbSet<APPartment.Models.Review> Review { get; set; }
    }
}
