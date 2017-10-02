﻿using menuAppBLL.BusinessObjects;
using menuAppBLL.Converters;
using menuAppDAL;
using menuAppDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;


namespace menuAppBLL.Services
{
    class MovieServices : IMovieService
    {
        private DALFacade facade;
        private IMovieRepository repo;
        private MovieConverter conv = new MovieConverter();

        public MovieServices(DALFacade facade)
        {
            this.facade = facade;
        }

        private Movie newMovie;

        public MovieBO Create(MovieBO movie)
        {
            using (var uow = facade.UnitOfWork)
            {
                newMovie = uow.MovieRepository.Create(conv.Convert(movie));
                uow.Complete();
                return conv.Convert(newMovie);
            }
        }

        public void CreateAll(List<MovieBO> movies)
        {
            using (var uow = facade.UnitOfWork)
            {


                foreach (var movie in movies)
                {
                    newMovie = uow.MovieRepository.Create(conv.Convert(movie));
                  
                }
                uow.Complete();
            }
        }


        public List<MovieBO> AddMovies(List<MovieBO> movies)
        {
            using (var uow = facade.UnitOfWork)
            {
                foreach (var movie in movies)
                {
                    uow.MovieRepository.Create(conv.Convert(movie));
                }

                uow.Complete();
                return movies;
            }
        }

        public MovieBO Delete(int Id)
        {
            using (var uow = facade.UnitOfWork)
            {
                var newMovie = uow.MovieRepository.Delete(Id);
                uow.Complete();
                return conv.Convert(newMovie);
            }
        }


        public MovieBO Get(int id)
        {
            using (var uow = facade.UnitOfWork)
            {
                return conv.Convert(uow.MovieRepository.Get(id));
            }
        }

        public List<MovieBO> GetAll()
        {
            using (var uow = facade.UnitOfWork)
            {
                // return uow.MovieRepository.GetAll();
                return uow.MovieRepository.GetAll().Select(conv.Convert).ToList();
            }
        }

        public MovieBO Update(MovieBO movie)
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
                return conv.Convert(movieFromDb);
            }
        }
    }
}
