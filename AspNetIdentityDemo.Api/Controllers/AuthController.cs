using AspNetIdentityDemo.Api.Dtos;
using AspNetIdentityDemo.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegisterViewModel = AspNetIdentityDemo.Api.Dtos.RegisterViewModel;

namespace AspNetIdentityDemo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }
        //api/auth/register
        [HttpPost("Register")]
        public async Task<ActionResult> RegisterAsync(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
               var result = await _userService.RegisterUserAsync(model);
                if (result.IsSuccess)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest(result);
                }
            }
            return BadRequest("Some properties are not valid!");
        }
    }
}
