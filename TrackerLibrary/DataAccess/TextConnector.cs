using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;
using System.Linq;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";

        // TODO - Make CreatePrize save to text file
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // Load text file
            // Convert text to List<prizeModel>
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            // Find the max Id
            int currentId = 1;
            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            // Add new Prize with New Id
            prizes.Add(model);

            // Convert prizes to List<string>
            // Save to text file
            prizes.SaveToPrizeFile(PrizesFile);

            return model;
        }
    }
}
