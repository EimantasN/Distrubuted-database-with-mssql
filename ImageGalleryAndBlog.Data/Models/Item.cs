using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        //Must Properties
        [Required]
        public int InStock { get; set; }

        [Required]
        public double Price { get; set; }

        public double Discount { get; set; }

        //General info about product
        [Required]
        public string Properties { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public bool Approved { get; set; }

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }


        public double RatingValue { get; set; }

        public int RatingCount { get; set; }

        public List<ImageSource> ItemImages { get; set; }
    }
}
