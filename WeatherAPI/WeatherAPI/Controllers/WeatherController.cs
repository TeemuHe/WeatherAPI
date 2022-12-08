using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("{city}")]
        public ActionResult<string> GetByCity(string city)
        {
            return city;
        }
    }
}
