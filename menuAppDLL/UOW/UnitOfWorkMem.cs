using System;
using System.Collections.Generic;
using System.Text;
using menuAppDAL.Context;
using Microsoft.EntityFrameworkCore.Storage.Internal;

namespace menuAppDAL.UOW
{
    class UnitOfWorkMem : IUnitOfWork
    {
        public IMovieRepository MovieRepository { get; internal set; }
        private InMemoryContext context;

        public UnitOfWorkMem()
        {
            context = new InMemoryContext();
            MovieRepository = new MovieRepositoryEFMemory(context);
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
