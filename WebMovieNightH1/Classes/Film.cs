using System;
using System.Collections.Generic;
using System.Text;

namespace WebMovieNightH1
{
    public class Film
    {

        #region Properties
        // Properties: setting private and defining set & get.

        private int filmId;
        private string title;
        private int year;
        // In SQl tabel film there is not a genre because it is multiple valued and has a table of its own
        // But to be able to print the genretype the class Film needs the attribut
        private string genreType;
        private string descript;

        public int FilmId
        {
            get
            { return FilmId; }
            set
            { filmId = value; }
        }
        public string Title
        {
            get
            { return title; }
            set
            { title = value; }
        }
        public int Year
        {
            get
            { return year; }
            set
            { year = value; }
        }
        public string GenreType
        {
            get
            { return genreType; }
            set
            { genreType = value; }
        }

        public string Descript
        {
            get
            { return descript; }
            set
            { descript = value; }
        }
        #endregion Properties.

        #region Constructors.
        // Making the constructors.
        // Meking to constructors since I need one without the genreType as well as one with it.
        public Film(int filmId, string title, int year, string descript)
        {
            this.filmId = filmId;
            this.title = title;
            this.year = year;
            this.descript = descript;
        }
        public Film(int filmId, string title, int year, string genreType, string descript):this(filmId, title, year, descript)
        {
            this.genreType = genreType;
            
        }
        #endregion Constructors.
    }
}
   
