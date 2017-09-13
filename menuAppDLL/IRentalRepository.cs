using System;
using System.Collections.Generic;
using System.Text;
using menuAppDAL.Entities;

namespace menuAppDAL.Repositories
{
    public interface IRentalRepository
    {

        //C
        Rental Create(Rental movie);
        //R
        List<Rental> GetAll();
        Rental Get(int id);
        //U
        // NO UPDATE FOR REPOSITORY
        //D
        Rental Delete(int Id);


    }
}
