using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HomeBnB.Models
{
    public class Renter
    {

        public int RenterID { get; set; }

        public string RenterName { get; set; }

        [EmailAddress]
        public string RenterEmail { get; set; }

        public virtual Apartment RenterApartment { get; set; }

    }
}
