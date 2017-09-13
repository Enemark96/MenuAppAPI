using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using menuAppDAL.Entities;


namespace menuAppDAL.Repositories
{
    class MovieRepositoryFakeDB : IMovieRepository
    {
        private static int Id = 0;
        private static List<Movie> Video = new List<Movie>();

        private Movie newMovie;

        public Movie Create(Movie movie)
        {
            Video.Add(newMovie = new Movie()
            {
                ID = Id++,
                VideoName = movie.VideoName,
                Genre = movie.Genre,

            });
            return newMovie;
        }

        public List<Movie> GetAll()
        {
            return new List<Movie>(Video);
        }

        public Movie Get(int id)
        {
            return Video.FirstOrDefault(x => x.ID == id);
        }

        public Movie Delete(int Id)
        {
            var movie = Get(Id);
            Video.Remove(movie);
            return movie;
        }
    }
}
