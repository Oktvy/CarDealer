using CarDealer.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarDealer.Controllers
{
    public class CategoriesController:Controller
    {
        public List<Categories> Categories;
        public CategoriesController()
        {
            Categories = new List<Categories>()
            {
                new Categories()
                {
                    Id=1,
                    BanType="Sedan"
                },
                new Categories()
                {
                    Id=2,
                    BanType="Jeep"
                },
                new Categories()
                {
                    Id=3,
                    BanType="SUV"
                },
                new Categories()
                {
                    Id=4,
                    BanType="Coupe"
                },
            };
        }
        public IActionResult Index()
        {
            ViewBag.Categories = Categories;
            return View(Categories);
        }

    }
}
