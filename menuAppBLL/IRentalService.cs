using System;
using System.Collections.Generic;
using System.Text;
using menuAppBLL.BusinessObjects;

namespace menuAppBLL
{
    public interface IRentalService
    {
        //C
        RentalBO Create(RentalBO movie);
        List<RentalBO> AddMovies(List<RentalBO> movies);
        //R
        List<RentalBO> GetAll();
        RentalBO Get(int id);
        //U
        RentalBO Update(RentalBO movie);
        //D
        RentalBO Delete(int Id);
    }
}
