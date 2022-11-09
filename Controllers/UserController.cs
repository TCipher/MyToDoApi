using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyToDoAPI.Interface;
using MyToDoAPI.Model;
using MyToDoAPI.Model.Dto;

namespace MyToDoAPI.Controllers
{
    //
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        //Assigning a field
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        //Bringing in our repository, and injecting it 
        public UserController(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
             _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<User>))]
        //Returns a List of users
        public async Task<IActionResult> GetUsers()
        {
            var user =  _mapper.Map<List<UserDto>>(await _userRepository.GetUsers());
            if (!ModelState.IsValid)
            
                return    BadRequest(ModelState);
                return Ok(user); 

        }
        //REturn a single user
        [HttpGet("{Id}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<User>))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> GetUser(int userid)
        {
            if( await _userRepository.UserExists(userid) == false)
                return NotFound();

            var user = _mapper.Map<UserDto>(await _userRepository.GetUser(userid));
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(user);
        }
       
        [HttpGet("{Id}/lastName")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<User>))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> GetUser(string username)
        {
           

            var user = _mapper.Map<UserDto>(await _userRepository.GetUser(username));
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(user);
        }
       

    } 
}

