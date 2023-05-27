using Microsoft.AspNetCore.Mvc;
using Services;

namespace intitalDraftForPracticeProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        Class1 cl = new Class1();

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }
        [HttpGet("ping")]
        public string ping()
        {
            return cl.ping();
        }
    }
}