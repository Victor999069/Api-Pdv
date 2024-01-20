using API_PDV.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_PDV.Data.Mapa
{
    public class UsuarioMap : IEntityTypeConfiguration<UsuarioModel>
    {
        public void Configure(EntityTypeBuilder<UsuarioModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.RazaoSocial).IsRequired().HasMaxLength(300);
            builder.Property(x => x.NomeFantasia).IsRequired().HasMaxLength(300);
            builder.Property(x => x.Cnpj).IsRequired().HasMaxLength(20);
            builder.Property(x => x.InscricaoEstadual).IsRequired().HasMaxLength(25);
            builder.Property(x => x.Cep).IsRequired().HasMaxLength(10);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Celular).IsRequired().HasMaxLength(25);

        }
    }
}
