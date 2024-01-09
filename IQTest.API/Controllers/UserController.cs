using IQTest.Core.DTOs;
using IQTest.Core.Models;
using IQTest.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace IQTest.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : CustomBaseController
    {
        private readonly IUserService _userService;
        private readonly SignInManager<UserApp> _signInManager;
        private readonly UserManager<UserApp> _userManager;

        public UserController(IUserService userService, UserManager<UserApp> userManager, SignInManager<UserApp> signInManager)
        {
            _userService = userService;
            _userManager = userManager;
            _signInManager = signInManager;
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

        [AllowAnonymous]
        public IActionResult FacebookLogin(string returnUrl)
        {
            string redirectUrl = Url.Action("FacebookResponse", "Home", new { returnUrl = returnUrl });
            var properties =  _signInManager.ConfigureExternalAuthenticationProperties("Facebook", redirectUrl);
            return new ChallengeResult("Facebook", properties);
            
        }

        [AllowAnonymous]
        public IActionResult GoogleLogin(string returnUrl)
        {
            string redirectUrl = Url.Action("FacebookResponse", "Home", new { returnUrl = returnUrl });
            var properties = _signInManager.ConfigureExternalAuthenticationProperties("Google", redirectUrl);
            return new ChallengeResult("Google", properties);

        }

        [AllowAnonymous]
        public async Task<IActionResult> SocialMediaResponse(string returnUrl)
        {
            var loginInfo = await _signInManager.GetExternalLoginInfoAsync();
            if (loginInfo == null)
            {
                return RedirectToAction("SignUp");
            }
            else
            {
                var result = await _signInManager.ExternalLoginSignInAsync(loginInfo.LoginProvider, loginInfo.ProviderKey, true);
                if (result.Succeeded)
                {
                    return Redirect("Index");
                }
                else
                {
                    if(loginInfo.Principal.HasClaim(c => c.Type == ClaimTypes.Email))
                    {
                        var user = new UserApp() { Email = loginInfo.Principal.FindFirstValue(ClaimTypes.Email),
                        UserName = loginInfo.Principal.FindFirstValue(ClaimTypes.Name)};

                        var createResult = await _userManager.CreateAsync(user);
                        if (createResult.Succeeded)
                        {
                            var identityLogin = await _userManager.AddLoginAsync(user, loginInfo);
                            if(identityLogin.Succeeded) 
                            {
                                await _signInManager.SignInAsync(user, true);
                                return Redirect("Login");
                            }
                        }
                        else
                        {
                            return BadRequest();
                        }
                    }
                }
            }

            return RedirectToAction("Signup");
        }
    }
}
