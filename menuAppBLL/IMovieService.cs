using System;
using System.Collections.Generic;
using System.Text;
using menuAppBLL.BusinessObjects;
using menuAppDAL.Entities;


namespace menuAppBLL
{
    public interface IMovieService
    {
        //C
        MovieBO Create(MovieBO movie);
        List<MovieBO> AddMovies(List<MovieBO> movies);
        //R
        List<MovieBO> GetAll();
        MovieBO Get(int id);
        //U
        MovieBO Update(MovieBO movie);
        //D
        MovieBO Delete(int Id);


    }
}
