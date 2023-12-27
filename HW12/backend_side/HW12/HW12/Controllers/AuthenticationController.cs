using HW12.DataBase;
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
        DataAccess dataAccess = new DataAccess("DataBase.json");

        [HttpPost]
        [Route("Signup")]
        public IActionResult SignUp([FromForm] SignupModel signupProperties)
        {
            TempDataBase.users = TempDataBase.LoadUsers("DataBase.json");
            signupProperties.ID = Guid.NewGuid();
            TempDataBase.users.Add(signupProperties);
            string jsonUsers = serialization.SerializeToJson(TempDataBase.users);
            dataAccess.SaveData(jsonUsers);
            return Ok(signupProperties);
        }

        [HttpPost]
        [Route("Signin")]
        public IActionResult SignIn([FromForm] SigninModel signinModel)
        {
            TempDataBase.users = TempDataBase.LoadUsers("DataBase.json");
            List<SignupModel> signupModels = dataAccess.ReadFile();
            var currentUser = signupModels.FirstOrDefault(m => m.Email == signinModel.Email && m.Password == signinModel.Password);

            if (currentUser == null)
            {
                //throw new Exception(message: "Incorrect email or password");
                return BadRequest();
            }
            else
            {
                return Ok(currentUser);
            }
        }

    }
}
