using Microsoft.AspNetCore.Mvc;
using MTechWebApi.Models;
using MTechWebApi.Services;

namespace MTechWebApi.Controller
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            var users = _userService.GetAllUsers();
            return Ok(users);
        }
    }
}