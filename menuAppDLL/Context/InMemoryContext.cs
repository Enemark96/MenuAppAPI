using System;
using System.Collections.Generic;
using System.Text;
using menuAppEntity;
using Microsoft.EntityFrameworkCore;

namespace menuAppDAL.Context
{
    class InMemoryContext : DbContext
    {
        static DbContextOptions<InMemoryContext> options =
            new DbContextOptionsBuilder<InMemoryContext>().UseInMemoryDatabase("TheDB").Options;

        //Options That we want in Memory
        public InMemoryContext() : base(options)
        {
            
        }

        public DbSet<Movie> Movies { get; set; }

    }
}
