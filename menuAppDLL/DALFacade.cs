using System;
using System.Collections.Generic;
using System.Text;
using menuAppDAL.Repositories;
using menuAppDAL.UOW;

namespace menuAppDAL
{
    public class DALFacade
    {
        public IUnitOfWork UnitOfWork => new UnitOfWork();
    }

  

}
