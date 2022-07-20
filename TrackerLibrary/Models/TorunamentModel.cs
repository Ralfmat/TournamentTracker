using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class TorunamentModel
    {
        /// <summary>
        /// Represents the tournament name.
        /// </summary>
        public string TorunamentName { get; set; }
        /// <summary>
        /// Represents the fee that has to be payed before entry.
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Represents the list of teams that entered the tournament.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; }
        /// <summary>
        /// Represents prizes of the tournament.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; }
        /// <summary>
        /// The set of rounds in the tournament.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; }

        public TorunamentModel()
        {
            EnteredTeams = new List<TeamModel>();
            Prizes = new List<PrizeModel>();
            Rounds = new List<List<MatchupModel>>();
        }

    }
}
