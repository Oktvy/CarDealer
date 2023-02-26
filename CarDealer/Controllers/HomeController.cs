using CarDealer.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarDealer.Controllers
{
    public class HomeController:Controller
    {
        public List<Cars> Cars;
       
        public HomeController()
        {
            Cars = new List<Cars>()
            {
                new Cars()
                {
                    Id=1,
                    Brand="Land Rover",
                    Model="Range Rover",
                    Year=2022,
                    Color="Black",
                    Image="https://i.ytimg.com/vi/qbRqySW39TI/maxresdefault.jpg",
                    Price=188175

                },
                new Cars()
                {
                    Id=2,
                    Brand="BMW",
                    Model="X5",
                    Year=2022,
                    Color="White",
                    Image="https://media.ed.edmunds-media.com/bmw/x5/2021/oem/2021_bmw_x5_4dr-suv_xdrive45e_fq_oem_2_815.jpg",
                    Price=59400

                },
                new Cars()
                {
                    Id=3,
                    Brand="Mercedes-Benz",
                    Model="AMG GT-63",
                    Year=2020,
                    Color="Green",
                    Image="https://img.tipcars.com/fotky_velke/18651041_1/1629221705/E/mercedes-benz-amg-gt-gtr.jpg",
                    Price=136500

                },
                new Cars()
                {
                    Id=4,
                    Brand="Kia",
                    Model="Stinger",
                    Year=2019,
                    Color="Gray",
                    Image="https://vehiclephotos.b-cdn.net/photos/vehicles/234168/4031736-large.jpg",
                    Price=37765

                },
                new Cars()
                {
                    Id=5,
                    Brand="Hyundai",
                    Model="Sonata",
                    Year=2009,
                    Color="White",
                    Image="https://cars.usnews.com/static/images/Auto/izmo/297410/2009_hyundai_sonata_angularfront.jpg",
                    Price=6000

                },
                new Cars()
                {
                    Id=6,
                    Brand="Chevrolet",
                    Model="Camaro",
                    Year=2022,
                    Color="Yellow",
                    Image="https://images.hgmsites.net/lrg/chevrolet_100179345_l.jpg",
                    Price=23000

                }

            };
           
            
        }
        public IActionResult Index()
        {

            return View(Cars);
        }

    }
}
