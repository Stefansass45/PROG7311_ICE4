using System.ComponentModel.DataAnnotations;

namespace PabloAPI.Model
{
    public class Product
    {
        [Key] 
        public int id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public double Price { get; set; }
    }
}
