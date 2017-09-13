using System;
using System.Collections.Generic;
using System.Text;

namespace menuAppDAL.Entities
{
    public class Rental
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime DeliveryDate { get; set; }  


    }
}
