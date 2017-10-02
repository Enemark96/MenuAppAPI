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
                RentalId = rental.Id,
                DeliveryDate = rental.DeliveryDate,
                OrderDate = rental.OrderDate,
                MovieID = rental.MovieID
            };
        }

        public RentalBO Convert(Rental rental)
        {
            return new RentalBO()
            {
                Id = rental.RentalId,
                DeliveryDate = rental.DeliveryDate,
                OrderDate = rental.OrderDate,

                Movie = new MovieConverter().Convert(rental.Movie),
                MovieID = rental.MovieID
            };
        }


    }
}
