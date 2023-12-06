using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using P05Shop.API.Services.AuthService;
using P05Shop.API.Services.BookDB;
using P06Shop.Shared;
using P06Shop.Shared.Auth;
using System.Security.Claims;

namespace P05Shop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   // [Authorize]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private IBookDB _bookDB;

        public AuthController(IAuthService authService, IBookDB bookDB)
        {
            this._authService = authService;
            this._bookDB = bookDB;
        }

        [HttpGet("Secret"), Authorize]
        public async Task<ActionResult<ServiceResponse<string>>> SecretText()
        {

            var response = await _bookDB.SecretAboutBook();
            if (!response.Success)
            {
                return BadRequest(response);
            }
            else 
            {
                return Ok(response);
            }
            
        }
        [HttpPost("login")]
        public async Task<ActionResult<ServiceResponse<string>>> Login(UserLoginDTO userLoginDTO)
        {
            var response = await  _authService.Login(userLoginDTO.Email, userLoginDTO.Password);
            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [HttpPost("register")]
        public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegisterDTO userRegisterDTO)
        {
            var user = new User()
            {
                Email = userRegisterDTO.Email,
                Username = userRegisterDTO.Username,
                Role = Roles.CUSTOMER
            };

            var response = await _authService.Register(user, userRegisterDTO.Password);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        
        }

        [HttpPost("change-password"), Authorize]
        public async Task<ActionResult<ServiceResponse<bool>>> ChangePassword([FromBody] string newPassword)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var response = await _authService.ChangePassword(int.Parse(userId), newPassword);
            if (!response.Success)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
    }
}
