using System.ComponentModel.DataAnnotations;

namespace MyShop.Models
{
    public class Product
    {
        [Required]
       public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
       
        public string? Description { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public float Price { get; set; }
    }
}
