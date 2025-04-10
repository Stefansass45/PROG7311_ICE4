using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http.HttpResults;
namespace WarDogsShop.Models { 
 public class Product
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public double Price { get; set; }
    }
}
