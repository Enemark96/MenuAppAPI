using System;
using System.Collections.Generic;
using System.Text;

namespace menuAppDAL
{
    public interface IUnitOfWork : IDisposable
    {
        IMovieRepository MovieRepository { get; }

        int Complete();
    }
}
