using System;
using System.Collections.Generic;
using System.Text;
using menuAppDAL.Repositories;
using menuAppDAL.UOW;

namespace menuAppDAL
{
    public class DALFacade
    {
        public IMovieRepository MovieRepository { get; } = new MovieRepositoryEFMemory(new Context.InMemoryContext());


        public IUnitOfWork UnitOfWork => new UnitOfWorkMem();
    }

  
}
