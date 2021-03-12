using System;
using System.Collections.Generic;
using System.Text;

namespace WebMovieNightH1
{
    public class FilmActor
    {   // Isn't used in this program but since it is a table in the SQL server I made a class for it as described in the assignment

        #region Properties.
        // Properties: setting private and defining set & get.

        private int filmId;
        private int actorId;

        public int FilmId
        {
            get
            { return filmId; }
            set
            { filmId = value; }
        }
        public int ActorId
        {
            get
            { return actorId; }
            set
            { actorId = value; }
        }
        #endregion Properties.

        #region Constructor.
        // Making the constructor.
        public FilmActor(int filmId, int actorId)
        {
            this.filmId = filmId;
            this.actorId = actorId;
        }
        #endregion Constructors.
    }
}

