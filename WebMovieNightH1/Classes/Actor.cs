using System;
using System.Collections.Generic;
using System.Text;

namespace WebMovieNightH1
{
    public class Actor
    {    // Properties: setting private and defining set & get.
        #region Properties.

        private int actorId;
        private string firstName;
        private string lastName;

        public int ActorId
        {
            get
            { return actorId; }
            set
            { actorId = value; }
        }
        public string FirstName
        {
            get
            { return firstName; }
            set
            { firstName = value; }
        }
        public string LastName
        {
            get
            { return lastName; }
            set
            { lastName = value; }
        }
        #endregion Properties.

        // Making the constructor.
        #region Constructor.
        public Actor(int actorId, string firstName, string lastName)
        {
            this.actorId = actorId;
            this.firstName = firstName;
            this.lastName = lastName;
        }
        #endregion Constructor.
    }

}
