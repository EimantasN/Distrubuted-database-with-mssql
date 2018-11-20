using ProductData.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SellerData.SellerModels
{
    public class Seller
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public bool Gender { get; set; }

        public string Description { get; set; }

        public double SuccessProcent { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string PostalCode { get; set; }

        public string PhoneNumber { get; set; }

        [Required]
        public bool Approved { get; set; }

        public Rating SellerRating { get; set; }

        public List<SellerItem> SellerItems { get; set; }
    }
}
