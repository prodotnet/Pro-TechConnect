using System.ComponentModel.DataAnnotations;

namespace Pro_TechConnect.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }
        [Required]
        public int CategoryId { get; set; }

        public string ImageUrl { get; set; }
        public Category Category { get; set; }
    }
}
