using System;
using System.Collections.Generic;
using System.Text;
using menuAppBLL.BusinessObjects;
using menuAppDAL.Entities;

namespace menuAppBLL.Converters
{
    class RentalConverter
    {
        public Rental Convert(RentalBO rental)
        {
            return new Rental()
            {
                Id = rental.Id,
                DeliveryDate = rental.DeliveryDate,
                OrderDate = rental.OrderDate
            };
        }

        public RentalBO Convert(Rental rental)
        {
            return new RentalBO(){
                Id = rental.Id,
                DeliveryDate = rental.DeliveryDate,
                OrderDate = rental.OrderDate
            };
        }


    }
}
