using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        /// <summary>
        /// Id for the Team
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents the list of people that are part of the team
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        /// <summary>
        /// Represents the name of the team
        /// </summary>
        public string TeamName { get; set; }
    }
}
