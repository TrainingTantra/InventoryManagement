using Microsoft.AspNetCore.Mvc;
using Services;

namespace intitalDraftForPracticeProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        PingService cl = new PingService();

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