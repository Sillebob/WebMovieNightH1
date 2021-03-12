using System;
using System.Collections.Generic;
using System.Text;

namespace WebMovieNightH1
{
    // Making the class static as in DalManager.
    public static class FilmManager
    {
        // Method that returns the movies from the DalManager.
        #region Method ReturnFilms.
        public static List<Film> ReturnFilms()
        {
            // Calling the method from DalManager , now this method can be called from Main.
            return DalManager.GetFilms();
        }
        #endregion Method ReturnFilms.
        #region Method ReturnFilmsNoGenre.
        public static List<Film> ReturnFilmsNoGenre()
        {
            // Calling the method from DalManager , now this method can be called from Main.
            return DalManager.GetFilmsNoGenre();
        }
        #endregion Method ReturnFilmsNoGenre.

        //Method that returns the actors from the DalManager.
        #region Method ReturnActors.
        public static List<Actor> ReturnActors()
        {
            // Calling the method from DalManager.
            return DalManager.GetActors();
        }
        #endregion Method ReturnActors.

        // Method that returns the movies that starts with an specific letter, in this case an A from the DalManager.
        #region Method SearchFilm.
        public static List<Film> SearchFilm(string letter)
        {
            // Calling the method from DalManager.
            return DalManager.SearchFilm(letter);
        }
        #endregion Method SearchFilms.

        // Method that returns the actors with an S from the DalManager.
        #region Method SearchActors.
        public static List<Actor> SearchActor(string letter)
        {
            // Calling the method from DalManager.
            return DalManager.SearchActor(letter);
        }
        #endregion Method SearchActors.

        // Method that returns the movies that starts with the genre Horror from the DalManager.
        #region Method SearchGenre.
        public static List<Film> SearchGenre(string genre)
        {
            // Calling the method from DalManager.
            return DalManager.SearchGenre(genre);
        }
        #endregion Method SearchGenre.
    }
}