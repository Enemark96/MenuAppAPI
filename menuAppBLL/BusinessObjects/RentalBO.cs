using System;
using System.Collections.Generic;
using System.Text;

namespace menuAppBLL.BusinessObjects
{
    public class RentalBO
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime DeliveryDate { get; set; }

        public int MovieID { get; set; }
        public MovieBO Movie { get; set; }


    }
}
