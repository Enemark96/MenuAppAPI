using System;
using System.Collections.Generic;
using System.Text;
using menuAppBLL;
using menuAppBLL.BusinessObjects;
using menuAppDAL.Entities;
using static System.Console;

namespace menuAppUI
{
    public class MovieById
    {
        static BLLFacade bllFacade = new BLLFacade();

        public static MovieBO FindMovieById()
        {
            WriteLine("Insert a movie Id:");
            int id;
            while (!int.TryParse(ReadLine(), out id))
            {
                WriteLine("Please insert a number");
            }
            return bllFacade.MovieServices.Get(id);
        }
    }
}
