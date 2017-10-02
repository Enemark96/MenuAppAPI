using menuAppBLL.BusinessObjects;
using menuAppDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace menuAppBLL.Converters
{
    public class MovieConverter
    {
        public Movie Convert(MovieBO movie)
        {
            if( movie == null) { return null; }
            return new Movie()
            {
                ID = movie.ID,
                VideoName = movie.VideoName,
                Genre = movie.Genre
            };
        }

        public MovieBO Convert(Movie movie)
        {
            if (movie == null) { return null; }
            return new MovieBO()
            {
                ID = movie.ID,
                VideoName = movie.VideoName,
                Genre = movie.Genre
            };
        }
    }
}
