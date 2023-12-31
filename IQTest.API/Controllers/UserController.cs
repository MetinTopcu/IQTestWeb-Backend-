using IQTest.Core.DTOs;
using IQTest.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IQTest.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : CustomBaseController
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Createuser(CreateUserDto createUserDto)
        {
            return CreateActionresult(await _userService.CreateUserAsync(createUserDto));
        }

        
        [HttpGet]
        public async Task<IActionResult> GetUser()
        {
            return CreateActionresult(await _userService.GetUserByNameAsync(HttpContext.User.Identity.Name));
        }

        [HttpPost("CreateUserRole")]
        [AllowAnonymous]
        public async Task<IActionResult> CreateUserRole(CreateUserRolesDTO createUserRolesDTO)
        {
            return CreateActionresult(await _userService.CreateUserRoles(createUserRolesDTO));
        }
        [HttpPost("CreateRole")]
        [AllowAnonymous]
        public async Task<IActionResult> CreateRole(CreateRolesDTO createRolesDTO)
        {
            return CreateActionresult(await _userService.CreateRoles(createRolesDTO));
        }
    }
}
