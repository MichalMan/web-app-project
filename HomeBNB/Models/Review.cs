using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeBnB.Models
{
    public class Review
    {
        public int ReviewID { get; set; }

        public int ReviewGrade { get; set; }

        public DateTime ReviewDate { get; set; }

        public string ReviewContent { get; set; }

        //public Renters Renter { get; set; }
    }
}
