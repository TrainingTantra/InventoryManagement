using InternalModels;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace intitalDraftForPracticeProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InventoryController : ControllerBase
    {
        PingService cl = new PingService();

        private readonly ILogger<InventoryController> _logger;

        public InventoryController(ILogger<InventoryController> logger)
        {
            _logger = logger;
        }
        [HttpGet("ping")]
        public string ping()
        {
            return cl.Ping();
        }
        [HttpGet("StudentDetails")]
        public IEnumerable<StudentDetails>? StudentDetails([FromHeader] int id)
        {
            var result = cl.StudentDetails(id);
            return result;
        }
    }
}