using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SellerData.SellerModels
{
    public class SellerRating
    {
        [Key]
        public int Id { get; set; }

        public double TotalValue { get; set; }

        public int ReviewCount { get; set; }

        // Json of Dictonary Time / Value for seller rating statistics, rare use cases so only json will be saved
        public List<string> SellerRatingHistory { get; set; }
    }
}
