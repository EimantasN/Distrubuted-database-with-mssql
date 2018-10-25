using Data.Models;
using ProductData.ProductModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.SellerModels
{
    public class Orders
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public Status Status { get; set; }

        [Required]
        public DateTime Created { get; set; }

        public User user { get; set; }

        public List<SellerItem> OrderItems { get; set; }
    }

    public enum Status
    {
        Incomplete,
        Pending,
        Awaiting_payment
    }
}
