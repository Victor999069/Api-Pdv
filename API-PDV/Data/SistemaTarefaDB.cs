using API_PDV.Controllers;
using API_PDV.Data.Mapa;
using API_PDV.Models;
using Microsoft.EntityFrameworkCore;

namespace API_PDV.Data
{
    public class SistemaTarefaDB : DbContext
    {
        //metodo de returno de dados do UiUsuario para aplicação em database
        public SistemaTarefaDB(DbContextOptions<SistemaTarefaDB> options)
            : base(options)
        {
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
