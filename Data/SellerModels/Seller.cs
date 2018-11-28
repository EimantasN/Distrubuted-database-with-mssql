using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SellerData.SellerModels
{
    public class Seller
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PostalCode { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public bool Gender { get; set; }

        public string Description { get; set; }

        public double SuccessProcent { get; set; }

        [Required]
        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        [Required]
        public bool Approved { get; set; }

        public Rating SellerRating { get; set; }

        public List<Item> SellerItems { get; set; }
    }
}
