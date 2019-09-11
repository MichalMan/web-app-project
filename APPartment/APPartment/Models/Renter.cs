using APPartment.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Appartment.Models
{
    public class Renter
    {

        public int RenterID { get; set; }

        public string RenterName { get; set; }

        [EmailAddress]
        public string RenterEmail { get; set; }

        public virtual Apartment RenterApartment { get; set; }
        public int ApartmentID { get; set; }
    }
}

