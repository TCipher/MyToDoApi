using Microsoft.AspNetCore.Mvc;
using MyToDoAPI.Interface;
using MyToDoAPI.Model;

namespace MyToDoAPI.Controllers
{
    //
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        //Assigning a field
        private readonly IUserRepository _userRepository;
        //Bringing in our repository, and injecting it 
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<User>))]
        public IActionResult GetUsers()
        {
            var user = _userRepository.GetUsers();
            if (!ModelState.IsValid)
            
                return BadRequest(ModelState);
                return Ok(user);
            

        }


    } 
}

