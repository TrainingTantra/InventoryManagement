using InternalModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services;
using Utils;

namespace intitalDraftForPracticeProject.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class InventoryController : ControllerBase
    {
        private readonly IPingService _pingService;
        private readonly ILogger<InventoryController> _logger;
        private readonly IAuthenticationManager _authenticationManager;
        public InventoryController(IPingService pingService, ILogger<InventoryController> logger, IAuthenticationManager authenticationManager)
        {
            _pingService = pingService;
            _logger = logger;
            _authenticationManager = authenticationManager;
        }

        [HttpGet("ping")]
        public string ping()
        {
            return _pingService.Ping();
        }
        [HttpGet("StudentDetails")]
        public IEnumerable<StudentDetails>? StudentDetails([FromHeader] int id)
        {
            var result = _pingService.StudentDetails(id);
            return result;
        }

        [HttpPost("Athenticator")]
        [AllowAnonymous]
        public IActionResult Authenticator([FromBody] UserCreds userCreds)
        {
            var token = _authenticationManager.Authenticator(userCreds.Name, userCreds.Password);
            if (token == null)
            {
                return Unauthorized();
            }
            return Ok(token);
        }
    }
}