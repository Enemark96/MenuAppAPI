using menuAppBLL;
using menuAppDAL.Entities;
using menuAppUI;
using System.Collections.Generic;
using menuAppBLL.BusinessObjects;
using static System.Console;

namespace Video_Menu
{
    class Program
    {
        static BLLFacade bllFacade = new BLLFacade();

        static void Main(string[] args)
        {
            UI();

            ReadLine();
        }

        public static void UI()
        {
            string[] menuItems =
            {
                "Create movie",
                "List movies",
                "Update movie",
                "Delete movie",
                "Exit"
            };

            //Show Menu
            //Wait for selection
            var selection = Menu.ShowMenu(menuItems);


            while (selection != 5)
            {
                switch (selection)
                {
                    case 1:
                        AddMovies();
                        break;
                    case 2:
                        ListMovies();
                        break;
                    case 3:
                        editMovies();
                        break;
                    case 4:
                        DeleteMovies();
                        break;
                }
                selection = Menu.ShowMenu(menuItems);


            }
            WriteLine("BYE BYE");

        }

        public static MovieBO AddMovie()
        {
            WriteLine("\nType in a movie Name: ");
            string name = ReadLine();

            WriteLine("\nType the movie genre: ");
            string genre = ReadLine();
            WriteLine("\n");

            MovieBO newMovie = new MovieBO() { VideoName = name, Genre = genre };
            return newMovie;
        }

        public static void AddMovies()
        {
            int selection;
            WriteLine("You chosed to add a movie");
            WriteLine("How many movies do you wanna add?");
            int.TryParse(ReadLine(), out selection);

            if (selection == 1)
            {
                bllFacade.MovieServices.Create(AddMovie());
            }
            else
            {
                List<MovieBO> movies = new List<MovieBO>();

                for (int i = 0; i < selection; i++)
                {
                    movies.Add(AddMovie());
                }

                bllFacade.MovieServices.AddMovies(movies);
            }
        }

        public static void ListMovies()
        {
            WriteLine("Movie List");
            foreach (var list in bllFacade.MovieServices.GetAll())
            {
                WriteLine($"MOVIE ID: {list.ID}, MOVIE NAME: {list.VideoName}, MOVIE GENRE: {list.Genre}");
            }
        }

        public static void DeleteMovies()
        {
            var movieFound = MovieById.FindMovieById();
            if (movieFound != null)
            {
                bllFacade.MovieServices.Delete(movieFound.ID);
            }
            var response = movieFound == null ? "Movie not found" : "Movie was deleted";

            WriteLine(response);

        }

        public static void editMovies()
        {
            var movieFound = MovieById.FindMovieById();
            if (movieFound != null)
            {
                WriteLine("Movie name: ");
                movieFound.VideoName = ReadLine();
                WriteLine("Genre");
                movieFound.Genre = ReadLine();
                bllFacade.MovieServices.Update(movieFound);
            }
            else
            {
                WriteLine("Movie not found");
            }

        }
    }
}