using System;
using System.Collections.Generic;
using System.Text;
using menuAppEntity;

namespace menuAppBLL
{
    public interface IMovieService
    {
        //C
        Movie Create(Movie movie);
        //R
        List<Movie> GetAll();
        Movie Get(int id);
        //U
        Movie Update(Movie movie);
        //D
        Movie Delete(int Id);


    }
}
