using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_PDV.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<UsuarioController>> BuscarUsuarios()
        {
            return Ok();
        }
    }
}
