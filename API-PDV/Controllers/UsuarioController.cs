using API_PDV.Models;
using API_PDV.Repositorios.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_PDV.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly UiUsuario _UsuarioRepo;
        //metodo controle de inserção UI do usuario
        public UsuarioController(UiUsuario UsuarioRepo) 
        {
            _UsuarioRepo = UsuarioRepo;
        }
        //Metodo buscar todos os usuarios cadastrados.
        [HttpGet]
        public async Task<ActionResult<List<UsuarioModel>>> BuscarUsuarios()
        {
            List<UsuarioModel> usuarios = await _UsuarioRepo.UsuarioBuscarTodos();
            return Ok();
        }
        //metodo buscar por id cadastrado automaticamente
        [HttpGet("{id}")]
        public async Task<ActionResult<UsuarioModel>> BuscarPorId(int id)
        {
            UsuarioModel usuario = await _UsuarioRepo.BuscarPorId(id);
            return Ok(usuario);
        }
        //metodo adicionar um novo cadastro
        [HttpPost]
        public async Task<ActionResult<UsuarioModel>> Adicionar([FromBody] UsuarioModel usuarioModel)
        {
            UsuarioModel usuario = await _UsuarioRepo.Adicionar(usuarioModel);
            return Ok(usuario);
        }
        //metodo atualizar cadastro
        [HttpPut("{id}")]
        public async Task<ActionResult<UsuarioModel>> Atualizar([FromBody] UsuarioModel usuarioModel, int id)
        {
            usuarioModel.Id = id;
            UsuarioModel usuario = await _UsuarioRepo.Atualizar(usuarioModel, id);
            return Ok(usuario);
        }
        //metodo deketar por id cadastrado
        [HttpDelete("{id}")]
        public async Task<ActionResult<UsuarioModel>> Apagar(int id)
        {
            bool apagar = await _UsuarioRepo.Apagar(id);
            return Ok(apagar);
        }
    }
}
