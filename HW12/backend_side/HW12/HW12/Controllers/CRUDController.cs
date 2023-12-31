using HW12.Models;
using HW12.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace HW12.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CRUDController : ControllerBase
    {
        CRUD crud = new CRUD();

        [HttpGet]
        [Route("GetAllUsers")]
        public IActionResult GetAllUsers()
        {
            return Ok(crud.ReadAllUsers());
        }

        [HttpPost]
        [Route("UpdateUser")]
        public IActionResult UpdateUser([FromForm] SignupModel model)
        {
            if (crud.UpdateUser(model)) return Ok();
            else return BadRequest();
        }
    }
}
