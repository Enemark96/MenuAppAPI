using System;
using System.Collections.Generic;
using System.Text;
using menuAppDAL.Repositories;

namespace menuAppDAL
{
    public interface IUnitOfWork : IDisposable
    {
        IMovieRepository MovieRepository { get; }
        IRentalRepository RentalRepository { get; }

        int Complete();
    }
}
