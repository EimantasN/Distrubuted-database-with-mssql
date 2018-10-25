using ProductData.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProductData.ProductModels
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Created { get; set; }

        [Required]
        public DateTime Updated { get; set; }

        public List<Item> CartItems { get; set; }
    }
}
