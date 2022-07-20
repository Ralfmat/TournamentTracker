using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        /// <summary>
        /// Represents members of the team.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; }
        /// <summary>
        /// Represents the team name.
        /// </summary>
        public string TeamName;

        public TeamModel()
        {
            TeamMembers = new List<PersonModel>();
        }
    }
}
