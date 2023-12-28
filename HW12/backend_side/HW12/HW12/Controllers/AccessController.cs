using HW12.DataBase;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HW12.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccessController : ControllerBase
    {
        [HttpPost]
        [Route("EnableUser")]
        public IActionResult EnableUser(string email)
        {
            var selectedUser = TempDataBase.users.FirstOrDefault(u => u.Email == email);
            selectedUser.IsDisable = "false";
            return Ok();
        }

        [HttpPost]
        [Route("DisableUser")]
        public IActionResult DisableUser(string email)
        { 
            var selectedUser = TempDataBase.users.FirstOrDefault(u => u.Email == email);
            selectedUser.IsDisable = "true";
            return Ok();
        }
    }
}
