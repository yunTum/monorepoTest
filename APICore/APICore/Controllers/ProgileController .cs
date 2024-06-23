using APICore.Models;
using Microsoft.AspNetCore.Mvc;

namespace APICore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfileController : ControllerBase
    {

        private readonly ILogger<ProfileController> _logger;

        public ProfileController(ILogger<ProfileController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetProfile")]
        public ProfileModel Get()
        {
            return new ProfileModel
            {
                Name = "Taro",
                MailAddress = "test@test.com"
            };
        }
    }
}
