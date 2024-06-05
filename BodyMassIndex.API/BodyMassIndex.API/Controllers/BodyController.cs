using BodyMassIndex.Domain;
using BodyMassIndex.Domain.TextService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace BodyMassIndex.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BodyController : ControllerBase
    {
        private readonly Service _services = new();

        [HttpPost("[action]")]

        public double Getbody(BodyMass bodyMass)
        {
            double body = bodyMass.weight / (bodyMass.lenght * bodyMass.lenght);
            _services.SaveText ($"kilo: {bodyMass.weight}, boy: {bodyMass.lenght},vücut kitle indeksi: {body}");
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
