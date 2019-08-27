using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HomeBNB.Models
{
    public class HomeBNBContext : DbContext
    {
        public HomeBNBContext (DbContextOptions<HomeBNBContext> options)
            : base(options)
        {
        }

        public DbSet<HomeBNB.Models.Apartments> Apartments { get; set; }
    }
}
