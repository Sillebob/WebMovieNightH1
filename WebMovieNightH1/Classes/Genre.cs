using System;
using System.Collections.Generic;
using System.Text;

namespace WebMovieNightH1
{
    public class Genre
    {

        #region Properties.
        // Properties: setting private and defining set & get.
        private int genreId;
        private string genreType;

        public int GenreId
        {
            get
            { return genreId; }
            set
            { genreId = value; }
        }
        public string GenreType
        {
            get
            { return genreType; }
            set
            { genreType = value; }
        }
        #endregion Properties.

        #region Constructor.
        // Making the constructor.
        public Genre(int genreId, string genreType)
        {
            this.genreId = genreId;
            this.genreType = genreType;
        }
        #endregion Constructor.
    }
}
