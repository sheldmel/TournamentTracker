using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class SqlConnector : IDataConnection
    {
        // TODO - Make the CreatePrize save to DB
        /// <summary>
        /// Saves a new prize to the DB
        /// </summary>
        /// <param name="model">The info about the prize</param>
        /// <returns>The prize information with its Id</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;
            return model;
        }
    }
}
