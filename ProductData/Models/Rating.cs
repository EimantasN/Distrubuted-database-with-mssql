using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProductData.Models
{
    public class Rating
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public double Value { get; set; }
        [Required]
        public int Count { get; set; }
    }
}
