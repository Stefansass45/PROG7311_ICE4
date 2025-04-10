using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WarDogsShop.Models;

namespace WarDogsShop.Controllers
{
    public class StoreController : Controller
    {
        private readonly DbConfig _context;

        public StoreController(DbConfig context)
        {
            _context = context;
        }

        // GET: Products
        public async Task<IActionResult> Index(string title)
        {
            StoreModel model = new StoreModel();

            model.Products = await _context.Product.ToListAsync();

            model.Category = title;


            return View(model);
        }


        //public IActionResult Index(string title)
        //{
        //    StoreModel model = new StoreModel();

        //    if (title != null)
        //    {
        //        model.title = title;
        //        return View(model);
        //    }


        //    model.title = "Store";
        //    return View(model);

        //}
    }
}
