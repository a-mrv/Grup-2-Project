using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalesApp.Domain.Entities;
using SalesApp.Domain.Services;

namespace SalesApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        CarService carService= new CarService();

        [HttpPost]
        public IActionResult Post([FromBody] Car car)
        {   car.Id = Guid.NewGuid();
            carService.Add(car);
            return Ok();
        }
        [HttpGet("[action]")]
        public IActionResult PrintToConsole() 
        {
            carService.PrintConsole();
            return Ok(); 
        }

        [HttpGet("[action]")]

        public IActionResult GetAll()
        {
            var cars = carService.GetAll();
            return Ok(cars);
        }

        [HttpDelete]
        public IActionResult Remove(Guid Id)
        {
            carService.Remove(Id);
            return Ok();

        }

        [HttpPost]
        public IActionResult UpDate(Guid Id,string Model)
        {
            carService.UpDate(Id,Model);
            return Ok();
        }
    }
}
