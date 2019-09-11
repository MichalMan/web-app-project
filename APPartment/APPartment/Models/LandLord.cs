using APPartment.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Appartment.Models
{
    public class LandLord
    {

        public int LandLordID { get; set; }

        public string Name { get; set; }

        [EmailAddress]
        public string LandLordEmail { get; set; }

        public int Rating { get; set; }

        public virtual ICollection<Apartment> Apartments { get; set; }
    }
}
