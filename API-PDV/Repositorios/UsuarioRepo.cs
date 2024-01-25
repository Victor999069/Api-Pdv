using API_PDV.Controllers;
using API_PDV.Data;
using API_PDV.Models;
using API_PDV.Repositorios.Interface;
using Microsoft.EntityFrameworkCore;

namespace API_PDV.Repositorios
{
    public class UsuarioRepo : UiUsuario
    {
        private readonly SistemaTarefaDB _dbContext;
        //metodo de tarefa de conexao com database
        public UsuarioRepo(SistemaTarefaDB SistemaTarefaDB) 
        { 
            _dbContext = SistemaTarefaDB;
        }
        
        public async Task<UsuarioModel> BuscarPorId(int id)
        {
            return await _dbContext.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<UsuarioModel>> UsuarioBuscarTodos()
        {
            return await _dbContext.Usuarios.ToListAsync();
        }

        public async Task<UsuarioModel> Adicionar(UsuarioModel usuario)
        {
            await _dbContext.Usuarios.AddAsync(usuario);
            await _dbContext.SaveChangesAsync();

            return usuario;
        }

        public async Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id)
        {
            UsuarioModel usuarioporId = await BuscarPorId(id);

            if (usuarioporId == null) 
            {
                throw new Exception($"Usuário para o ID: {id} não encontrado.");
            }
            
            usuarioporId.NomeFantasia = usuario.NomeFantasia;
            usuarioporId.RazaoSocial = usuario.RazaoSocial;

            _dbContext.Usuarios.Update(usuarioporId);
            await _dbContext.SaveChangesAsync();

            return usuarioporId;
        }

        public async Task<bool> Apagar(int id)
        {
            UsuarioModel usuarioporId = await BuscarPorId(id);

            if (usuarioporId == null)
            {
                throw new Exception($"Usuário para o ID: {id} não encontrado.");
            }

            _dbContext.Usuarios.Remove(usuarioporId);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        
    }
}
