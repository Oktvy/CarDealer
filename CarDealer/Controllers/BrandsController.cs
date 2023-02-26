using CarDealer.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarDealer.Controllers
{
    public class BrandsController:Controller
    {
        public List<Brands> Brands;
        public BrandsController()
        {
            Brands = new List<Brands>()
            {
                new Brands
                {
                    Id=1,
                    BrandName="Land Rover"
                },
                new Brands
                {
                    Id=2,
                    BrandName="BMW"
                },
                new Brands
                {
                    Id=3,
                    BrandName="Mercedes-Benz"
                },
                new Brands
                {
                    Id=4,
                    BrandName="Kia"
                },
                new Brands
                {
                    Id=5,
                    BrandName="Hyundai"
                },
                new Brands
                {
                    Id=6,
                    BrandName="Chevrolet"
                },
            };
        }
        public IActionResult Index()
        {
            ViewBag.Brands = Brands;
            return View(Brands);
        }

    }
}
