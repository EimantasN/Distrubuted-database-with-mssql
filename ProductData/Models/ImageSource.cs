using System.ComponentModel.DataAnnotations;

namespace ProductData.Models
{
    public class ImageSource
    {
        [Key]
        public int Id { get; set; }

        public string Thumbnail { get; set; }
        [Required]
        public string Original { get; set; }
    }
}
