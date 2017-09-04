using System;
using System.Collections.Generic;
using System.Text;
using menuAppBLL.Services;
using menuAppDAL;

namespace menuAppBLL
{
    public class BLLFacade
    {
        public IMovieService MovieServices { get; } = new MovieServices(new DALFacade());
    }
}
