using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Represents the number of the place 
        /// that the prize is being awarded for
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Represents the name of the place 
        /// that the prize is being awarded for
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Represents the amount of prize money
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Represents the percentage of prize money awarded
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
