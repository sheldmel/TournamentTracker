using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
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
