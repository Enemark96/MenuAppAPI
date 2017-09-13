using System;
using System.Collections.Generic;
using System.Text;
using menuAppDAL.Context;
using menuAppDAL.Repositories;
using Microsoft.EntityFrameworkCore.Storage.Internal;

namespace menuAppDAL.UOW
{
    class UnitOfWork : IUnitOfWork
    {
        public IMovieRepository MovieRepository { get; internal set; }
        public IRentalRepository RentalRepository { get; internal set; }

        private MovieAppContext context;

        public UnitOfWork()
        {
            context = new MovieAppContext();
            MovieRepository = new MovieRepositoryEFMemory(context);
            RentalRepository = new RentalRepository(context);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public int Complete()
        {
           return context.SaveChanges();
        }
    }
}
