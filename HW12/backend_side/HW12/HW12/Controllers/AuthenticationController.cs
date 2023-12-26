using HW12.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HW12.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        [HttpPost]
        [Route("Signup")]
        public IActionResult SignUp(SignupModel signupProperties)
        {
            signupProperties.ID = Guid.NewGuid();
            return Ok();
        }

    }
}
