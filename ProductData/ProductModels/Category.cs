using ProductData.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProductData.ProductModels
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime Created { get; set; }

        [Required]
        public int ItemsCount { get; set; }

        public List<Category> SubCategorys { get; set; }
        public List<Item> CategoryItems { get; set; }
    }
}
