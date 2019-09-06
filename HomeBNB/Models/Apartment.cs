using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeBnB.Models
{
    public class Apartment
    {

        public int ApartmentID { get; set; }

        public string Owner { get; set; }

        public string Address { get; set; }

        public int NumberOfRooms { get; set; }

        public bool Renovated { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }
        public virtual LandLord LandLord { get; set; }

    }
}
