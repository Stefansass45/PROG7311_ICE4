using Microsoft.AspNetCore.Mvc;
using WarDogsShop.Models;

namespace WarDogsShop.Controllers
{
    public class StoreController : Controller
    {
        //public IActionResult Index()
        //{
        //    StoreModel model = new StoreModel();

        //    return View(model);
        //}

        public IActionResult Index(string title)
        {
            StoreModel model = new StoreModel();

            if (title != null)
            {
                model.title = title;
                return View(model);
            }


            model.title = "Store";
            return View(model);





        }
    }
}
