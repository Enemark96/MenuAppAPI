using System;
using System.Collections.Generic;
using System.Text;

namespace menuAppDAL.Entities
{
    public class Rental
    {
        public int RentalId { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime DeliveryDate { get; set; }


        public int MovieID { get; set; }
        public Movie Movie { get; set; }


    }
}
