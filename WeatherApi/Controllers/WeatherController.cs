using Microsoft.AspNetCore.Mvc;
using Services.Interface;

namespace WeatherApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherController : ControllerBase
    {
        private readonly IWeatherService _weatherService;

        public WeatherController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet(Name = "GetTemperature")]
        public IActionResult GetTemperature(string city)
        {
            return Ok(_weatherService.GetTemperature(city));
        }
    }
}