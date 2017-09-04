using System;
using System.Collections.Generic;
using System.Text;
using menuAppBLL;
using menuAppEntity;
using static System.Console;

namespace menuAppUI
{
    public class MovieById
    {
        static BLLFacade bllFacade = new BLLFacade();

        public static Movie FindMovieById()
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
