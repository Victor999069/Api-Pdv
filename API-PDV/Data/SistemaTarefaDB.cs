using API_PDV.Controllers;
using API_PDV.Models;
using Microsoft.EntityFrameworkCore;

namespace API_PDV.Data
{
    public class SistemaTarefaDB : DbContext
    {
        public SistemaTarefaDB(DbContextOptions<SistemaTarefaDB> options)
            : base(options)
        {
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
