﻿using API_PDV.Controllers;
using API_PDV.Models;

namespace API_PDV.Repositorios.Interface
{
    public interface UiUsuario
    {
        //metodos de renderização do UI que retorna da UsuarioModel que é a base de inserção de dados da API
        Task<List<UsuarioModel>> UsuarioBuscarTodos();
        Task<UsuarioModel> BuscarPorId(int id);
        Task<UsuarioModel> Adicionar(UsuarioModel usuario);
        Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id);
        Task<bool> Apagar(int id);
    }
}
