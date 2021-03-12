using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace WebMovieNightH1
{
    class Program
    {
        static void Main(string[] args)
        {

            #region GetMovies.
            // Calling the Filmmanager to get a list of all the movietitles.
            List<Film> film = FilmManager.ReturnFilms();

            // Calling the method to display headline.
            GetHeadLine("List of all the movietitles, the released year and the genre.");

            // Printing The titles.
            // It prints the movies twice since every movie has to genres and they are in a combined table in SQL.
            PrintFilmGenre(film);
            #endregion GetMovies.

            #region GetMoviesTitleYear.
            // Calling the Filmmanager to get a list of all the movietitles.
            List<Film> filmTY = FilmManager.ReturnFilmsNoGenre();

            // Calling the method to display headline.
            GetHeadLine("\nList of all the movietitles and the released year.");

            // Printing The titles.
            PrintFilm(filmTY);
            #endregion GetMoviesTitelYear.

            #region GetActors.
            // Calling the Filmmanager to get a list of all the actors.
            List<Actor> actor = FilmManager.ReturnActors();

            // Calling the method to display headline.
            GetHeadLine("\nList of all the actors first and lastname.");

            // Printing the names.
            PrintActor(actor);
            #endregion GetActors.
           
            #region FilmSearch.
            // Calling the Filmmanager to get a list of all the movietitles that starts with A
            // Here there could be a Console.ReadLine instead to get the users input of what to search for
            List<Film> filmA = FilmManager.SearchFilm("A");

            // Calling the method to display headline.
            GetHeadLine("\nList of all the movietitles that starts with A.");

            // Printing The titles.
            PrintFilm(filmA);

            // There could be a console.WriteLine to inform the user if yhere where no matches found.
            #endregion FilmSearch.

            #region SearchActor.
            // Calling the Filmmanager to get a list of all the actors with an S
            List<Actor> actorS = FilmManager.SearchActor("S");

            // Calling the method to display headline.
            GetHeadLine("\nList of all the actors with an S.");

            // Printing the names.
            PrintActor(actorS);
            // There could be a Console.Writeline to inform the user if yhere where no matches found.
            #endregion SearchActor.

            #region SerachGenre.
            // Calling the Filmmanager to get a list of all the movietitles that has the genre horror
            List<Film> filmHorror = FilmManager.SearchGenre("Horror");

            // Calling the method to display headline.
            GetHeadLine("\nList of all the movietitles with the genre horror.");

            // Printing The titles.
            PrintFilmGenre(filmHorror);
            // There could be a Console.WriteLine to inform the user if yhere where no matches found.
            #endregion SearchGenre.

            Console.ReadKey();
        }
        // Methods.
        // Method to print description/headline of what is being displayed.
        #region PrintHeadLine.
        public static void GetHeadLine(string headLine)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(headLine);
            Console.ForegroundColor = ConsoleColor.White;
        }
        #endregion PrintHeadLine

        // Method to print the list of movies (only title and year).
        #region Method PrintFilm.
        public static void PrintFilm(List<Film> name)
        {
            foreach (Film item in name)
            {
                Console.WriteLine($"{item.Title,-18} {item.Year}");
            }

        }
        #endregion PrintFilm.

        // Method to print the movies with genre.
        #region Method PrintFilmGenre.
        public static void PrintFilmGenre(List<Film> name)
        {
            foreach (Film item in name)
            {
                Console.WriteLine($"{item.Title,-18} {item.Year} {item.GenreType}");
            }
        }
        #endregion PrintFilmGenre.

        // Method to print the actors. 
        #region PrintActor.
        public static void PrintActor(List<Actor> name)
        {
            foreach (Actor item in name)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
        }
        #endregion PrintActor.

        
    }
}
