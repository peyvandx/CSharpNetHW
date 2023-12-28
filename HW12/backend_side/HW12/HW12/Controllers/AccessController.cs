using HW12.DataBase;
using HW12.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HW12.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccessController : ControllerBase
    {
        Serialization serialization = new Serialization();
        DataAccess dataAccess = new DataAccess("DataBase.json");

        [HttpPost]
        [Route("EnableUser")]
        public IActionResult EnableUser([FromBody] string email)
        {
            TempDataBase.users = TempDataBase.LoadUsers("DataBase.json");
            var selectedUser = TempDataBase.users.FirstOrDefault(u => u.Email == email);
            selectedUser.IsDisable = "false";
            string jsonUsers = serialization.SerializeToJson(TempDataBase.users);
            dataAccess.SaveData(jsonUsers);
            return Ok();
        }

        [HttpPost]
        [Route("DisableUser")]
        public IActionResult DisableUser([FromBody] string email)
        {
            TempDataBase.users = TempDataBase.LoadUsers("DataBase.json");
            var selectedUser = TempDataBase.users.FirstOrDefault(u => u.Email == email);
            selectedUser.IsDisable = "true";
            string jsonUsers = serialization.SerializeToJson(TempDataBase.users);
            dataAccess.SaveData(jsonUsers);
            return Ok();
        }
    }
}
