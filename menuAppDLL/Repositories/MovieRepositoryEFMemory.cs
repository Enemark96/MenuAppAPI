using System;
using System.Collections.Generic;
using System.Text;
using menuAppDAL.Context;

using System.Linq;
using menuAppDAL.Entities;


namespace menuAppDAL
{
    class MovieRepositoryEFMemory : IMovieRepository
    {
        private readonly MovieAppContext _context;

        public MovieRepositoryEFMemory(MovieAppContext context)
        {
            _context = context;
        }
        
        public Movie Create(Movie movie)
        {
            _context.Movies.Add(movie);       
            return movie;
        }

        public List<Movie> GetAll()
        {
            return _context.Movies.ToList();
        }

        public Movie Get(int id)
        {
            return _context.Movies.FirstOrDefault(x => x.ID == id);
        }

        public Movie Delete(int Id)
        {
            var movie = Get(Id);
            _context.Movies.Remove(movie);      
            return movie;
        }
    }
}
