using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APPartment.Models
{
    public class Review
    {

        public int ReviewID { get; set; }

        public int ReviewGrade { get; set; }

        public DateTime ReviewDate { get; set; }

        public string ReviewContent { get; set; }
        public int LandLordID { get; set; }

        public int ApartmentID { get; set; }
    }
}
