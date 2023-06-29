using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UsersAPI.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        ///<summary>
        ///autenticar o usaurio
        ///</summary>
        [Route("login")]
        [HttpPost]
        public IActionResult Login()
        {
            return Ok();
        }

        ///<summary>
        ///recuparerar senha de acesso do usaurio
        ///</summary>
        [Route("forgot-password")]
        [HttpPost]
        public IActionResult ForgotPassword()
        {
            return Ok();
        }
        ///<summary>
        ///Alterar a senha de acesso do usaurio
        ///</summary>
        [Route("reset-password")]
        [HttpPost]
        public IActionResult ResetPassword()
        {
            return Ok();
        }
    }
}
