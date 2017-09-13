using System;
using System.Collections.Generic;
using System.Text;
using menuAppDAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace menuAppDAL.Context
{
    class MovieAppContext : DbContext
    {
        static DbContextOptions<MovieAppContext> options =
            new DbContextOptionsBuilder<MovieAppContext>().UseInMemoryDatabase("TheDB").Options;

        //Options That we want in Memory
        public MovieAppContext() : base(options)
        {
            
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Rental> Rentals { get; set; }

    }
}
