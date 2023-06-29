using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UsersAPI.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        //Criar conta de usuario
        [HttpPost]
        public IActionResult Add()
        {
            return Ok();
        }
        ///<summary>
        ///Alterar dados do usuario
        ///</summary>
        [HttpPut]
        public IActionResult Update()
        {
            return Ok();
        }
        ///<summary>
        ///Excluir conta de usuario
        ///</summary>
        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok();
        }
        ///<summary>
        ///Consultar conta de usuario
        ///</summary>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
