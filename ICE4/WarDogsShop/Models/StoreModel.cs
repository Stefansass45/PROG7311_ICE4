using System.ComponentModel.DataAnnotations;

namespace WarDogsShop.Models
{
    public class StoreModel
    {
        public string Category { get; set; }
        public IEnumerable<Product> Products { get; set; }



    }
}
