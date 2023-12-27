using HW12.Models;
using HW12.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HW12.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        Serialization serialization = new Serialization();
        DataAccess dataAccess = new DataAccess(Directory.GetCurrentDirectory() + @"\DataBase.json");

        [HttpPost]
        [Route("Signup")]
        public IActionResult SignUp([FromForm] SignupModel signupProperties)
        {
            signupProperties.ID = Guid.NewGuid();
            string json = serialization.SerializeToJson(signupProperties);
            dataAccess.SaveData(json);
            return Ok(signupProperties);
        }

    }
}
