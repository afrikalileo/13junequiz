using Microsoft.AspNetCore.Mvc;
using carwebbapp1.Models;

namespace carwebbapp1.Controllers
{
    public class HomeController : Controller

    {
       CarContext carContext = new CarContext();
        public IActionResult Index()

        {

            List<Car> carsl = carContext.Carslist.ToList();   

            return View(carsl);
        }

        [HttpGet]

        public IActionResult Add()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Add(Car cars)
        {
            carContext.Carslist.Add(cars);
            carContext.SaveChanges();
            return View();
        }
    }
}
