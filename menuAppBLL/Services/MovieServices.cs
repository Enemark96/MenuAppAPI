using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using menuAppDAL;
using menuAppEntity;
using static System.Console;


namespace menuAppBLL.Services
{
    class MovieServices : IMovieService
    {
        private DALFacade facade;
        private IMovieRepository repo;

        public MovieServices(DALFacade facade)
        {
            this.facade = facade;
        }

        private Movie newMovie;

        public Movie Create(Movie movie)
        {
            using (var uow = facade.UnitOfWork)
            {
                var newMovie = uow.MovieRepository.Create(movie);
                uow.Complete();
                return newMovie;
            }
        }

        public Movie Delete(int Id)
        {
            using (var uow = facade.UnitOfWork)
            {
                var newMovie = uow.MovieRepository.Delete(Id);
                uow.Complete();
                return newMovie;
            }
        }


        public Movie Get(int id)
        {
            using (var uow = facade.UnitOfWork)
            {
                return uow.MovieRepository.Get(id);
            }
        }

        public List<Movie> GetAll()
        {
            using (var uow = facade.UnitOfWork)
            {
                return uow.MovieRepository.GetAll();
            }
        }

        public Movie Update(Movie movie)
        {
            using (var uow = facade.UnitOfWork)
            {
                var movieFromDb = uow.MovieRepository.Get(movie.ID);
                if (movieFromDb == null)
                {
                    throw new InvalidOperationException("Movie not found");
                }

                movieFromDb.VideoName = movie.VideoName;
                movieFromDb.Genre = movie.Genre;
                uow.Complete();
                return movieFromDb;
            }
        }
    }
}
