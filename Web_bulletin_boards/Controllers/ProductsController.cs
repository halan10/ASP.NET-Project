using Microsoft.AspNetCore.Mvc;
using Web_bulletin_boards.Models;

namespace Web_bulletin_boards.Controllers
{
    public class ProductsController : Controller
    {
       static List<Car> cars = new List<Car>() 
       {

            new Car() { Id = 1,Name = "Mazda", Model = "6",Year = 2008,  Category = "Auto", City = "Kharkiv",
                Description = "Engine, gearbox, running gear are normal. There are a few flaws in the bodywork, I didn’t do it myself, I’ll throw it off for this. Traffic exchange, vivaro" ,
                Price = 7700, PhoneNumber = "+380665051414", Email = "igor-@ukr.net", Image="https://cdn4.riastatic.com/photosnew/auto/photo/mazda_6__487162014f.webp"},
            
            new Car() { Id = 2,Name = "Honda", Model = "Civic",Year = 2008,  Category = "Auto", City = "Dnipro",
                Description = "Honda Civic for sale. 1.8 engine, automatic gearbox, the car has been technically" ,
                Price = 6900, PhoneNumber = "+380995051554", Email = "Nikolay@gmail.com", Image="https://cdn0.riastatic.com/photosnew/auto/photo/honda_civic__488448490f.webp"},
           
            new Car() { Id = 3,Name = "Skoda", Model = "Octavia",Year = 2021,  Category = "Auto", City = "Kryvyi Rih",
                Description = "Engine, gearbox, running gear are normal. There are a few flaws in the bodywork, I didn’t do it myself, I’ll throw it off for this. Traffic exchange, vivaro" ,
                Price = 25500, PhoneNumber = "+380954051018", Email = "Olexandra12@ukr.net", Image="https://cdn0.riastatic.com/photosnew/auto/photo/skoda_octavia__487502215f.webp"},
           
            new Car() { Id = 4,Name = "Tesla", Model = "Model 3",Year = 2019,  Category = "Auto", City = "Kyiv",
                Description = "The car was restored with original spare parts. No restoration. Installed: European optics European mirrors Fast charging via CCS 2 adapter" ,
                Price = 31999, PhoneNumber = "+380985082540", Email = "tesladualmotor@ukr.net", Image="https://cdn0.riastatic.com/photosnew/auto/photo/tesla_model-3__482202170f.webp"},
          
            new Car() { Id = 5,Name = "Audi", Model = "A4",Year = 2002,  Category = "Auto", City = "Cherkasy",
                Description = "The machine is in good condition, the timing belt, rollers, pump, thermostat, oils and filters have been changed." ,
                Price = 5500, PhoneNumber = "+380665554114", Email = "YuraA4@.proton@.mail", Image="https://cdn1.riastatic.com/photosnew/auto/photo/audi_a4__446608246f.webp"}
        };

        public IActionResult Index()
        {
            return View(cars);
        }
        public IActionResult Delete(int id)
        {
            var item = cars.FirstOrDefault(x => x.Id == id);
            if (item == null)
                return NotFound();
            cars.Remove(item);
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            var item = cars.FirstOrDefault(x => x.Id == id);
            if (item == null)
                return NotFound();

            return View(item);
        }
        public IActionResult Back()
        {
            return RedirectToAction("Index");
        }
    }
}
