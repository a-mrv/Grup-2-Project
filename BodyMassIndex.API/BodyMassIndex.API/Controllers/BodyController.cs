using BodyMassIndex.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace BodyMassIndex.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BodyController : ControllerBase
    {
        [HttpPost("[action]")]

        public double Getbody(BodyMass BodyMass)
        {
            double body = BodyMass.weight / (BodyMass.lenght * BodyMass.lenght);
            Console.WriteLine($"kilo: {BodyMass.weight}, boy: {BodyMass.lenght},vücut kitle indeksi: {body}");
            return body;

        }

        [HttpGet("[action]")]

        public string Getweight(double body)
        {
            if (body < 18.5)   
            return "zayıf";
          
            else if (body > 24.9)
                return "kilolu";
            else if (body <= 24.9 && body >= 18.5) 
                return "ideal kilo";
            else
                return "";
            

        }
    }
}
