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
        //public MovieAppContext() : base(options)
        //{

        //}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    @"Server=tcp:jaco6143.database.windows.net,1433;Initial Catalog=MenuAPP;Persist Security Info=False;User ID=jaco6143;Password=Jacob123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Rental> Rentals { get; set; }

    }
}
