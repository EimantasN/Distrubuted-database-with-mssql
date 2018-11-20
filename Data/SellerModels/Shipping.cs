using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SellerData.SellerModels
{
    public class Shipping
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Method Method { get; set; }
        [Required]
        public DateTime Created { get; set; }
        [Required]
        public bool Notifications { get; set; }

        [Required]
        public DateTime ExpectedTime { get; set; }

        [Required]
        public Orders OrderInfo { get; set; }
    }

    public enum Method
    {
        InStore,
        ToHome, PostOffice,
        LpExpress,
        Omniva
    }
}
