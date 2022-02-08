using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDbCrudOperationTemplate.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongodbCrudOperationTemplate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserServices _userServices;

        public UsersController(IUserServices tt)
        {
            _userServices = tt;

        }

        [HttpGet]
        public IActionResult GetUsers(){

            return Ok(_userServices.GetUsers());
        }


        [HttpGet("{user}", Name = "GetUser")]
        public IActionResult GetUser(string user)
        {
            return Ok(_userServices.GetUser(user));
        }

        [HttpPost]
        public IActionResult AddUser(user user)
        {
            _userServices.AddUser(user);
            return CreatedAtRoute("GetUser", new { user = user.User }, user);
        }

        [HttpDelete("{user}")]
        public IActionResult DeleteUser(string user)
        {
            _userServices.DeleteUser(user);
            return NoContent();
        }

        [HttpPut]
        public IActionResult UpdateUser(user user)
        {
            return Ok(_userServices.UpdateUser(user));
        }



    }
}
