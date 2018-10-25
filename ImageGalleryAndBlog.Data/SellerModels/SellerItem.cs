using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.SellerModels
{
    public class SellerItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int FullItemId { get; set; }

        [Required]
        public string Name { get; set; }

        //Creation
        [Required]
        public DateTime Created { get; set; }
    }
}
