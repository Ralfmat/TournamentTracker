using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents prize of the tournament.
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// Represents id of the prize.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Number of the place winner have to obtain to get the prize.
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Represents the name of the place.
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Represents the prize amount for the place.
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Represnts the percentage of the prize winner gets for the place.
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {
            
        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }

    }
}
