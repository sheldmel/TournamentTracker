using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Id for the matchup entry
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents One team in the matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Represents score for the particular team
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Represents the matchup that the team won
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
