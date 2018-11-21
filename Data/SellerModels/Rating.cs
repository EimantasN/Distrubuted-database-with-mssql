using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SellerData.SellerModels
{
    public class Rating
    {
        [Key]
        public int Id { get; set; }

        public double TotalValue { get; set; }

        public int ReviewCount { get; set; }
    }
}
