using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
   public class MatchupModel
    {
        /// <summary>
        /// Id for the matchup
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents a list of matchup entries
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Represents which team was the winner of a matchup
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Represents the round in which the matchup took place 
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
