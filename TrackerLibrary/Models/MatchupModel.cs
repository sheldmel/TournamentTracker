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
        /// Id from database that will be used to find winner.
        /// </summary>
        public int WinnerId { get; set; }
        /// <summary>
        /// Represents which team was the winner of a matchup
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Represents the round in which the matchup took place 
        /// </summary>
        public int MatchupRound { get; set; }

        public string DisplayName {
            get 
            {
                string o = "";
                foreach (MatchupEntryModel me in Entries)
                {
                    if(me.TeamCompeting != null)
                    {
                        if (o.Length == 0)
                        {
                            o = me.TeamCompeting.TeamName;
                        }
                        else
                        {
                            o += $" vs. { me.TeamCompeting.TeamName }";
                        }
                    }
                    else
                    {
                        o = "Matchup Not Yet Determined.";
                        break;
                    }
                }
                return o;
            } 
        }
    }
}
