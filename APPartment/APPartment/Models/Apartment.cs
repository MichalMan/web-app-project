using Appartment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APPartment.Models
{
    public class Apartment
    {

        public int ApartmentID { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "streetAddress")]
        public string Address { get; set; }
        public int NumberOfRooms { get; set; }
        public bool Renovated { get; set; }

        public double Price { get; set; }
        public string Description { get; set; }

        public virtual LandLord LandLord { get; set; }
        public int LandLordID { get; set; }

    }
}
