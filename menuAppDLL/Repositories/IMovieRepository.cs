using System;
using System.Collections.Generic;
using System.Text;
using menuAppEntity;

namespace menuAppDAL
{
    public interface IMovieRepository
    {
        //C
        Movie Create(Movie movie);
        //R
        List<Movie> GetAll();
        Movie Get(int id);
        //U
        // NO UPDATE FOR REPOSITORY
        //D
        Movie Delete(int Id);

    }
}
