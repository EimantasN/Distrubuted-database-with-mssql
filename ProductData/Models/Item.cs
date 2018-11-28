using ProductData.ProductModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProductData.Models
{
    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

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
        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }


        [Required]
        public bool Approved { get; set; }

        public Rating ItemRating { get; set; }
        public List<ImageSource> ItemImages { get; set; }
    }
}
