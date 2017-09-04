using System;
using System.Collections.Generic;
using menuAppBLL;
using menuAppDAL;
using menuAppEntity;
using menuAppUI;
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
                        AddMovie();
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

        public static void AddMovie()
        {
        
            WriteLine("Create a movie");

            WriteLine("\nType in a movie Name: ");
            string name = ReadLine();

            WriteLine("\nType the movie genre: ");
            string genre = ReadLine();
            WriteLine("\n");

            WriteLine($"You created a movie with the NAME: {name} and GENRE: {genre}");

            bllFacade.MovieServices.Create(new Movie()
            {
                VideoName = name,
                Genre = genre,
            });
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