using API_PDV.Data;
using API_PDV.Repositorios;
using API_PDV.Repositorios.Interface;
using Microsoft.EntityFrameworkCore;

namespace API_PDV
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            #region metodo de criação de banco de dados local 
            builder.Services.AddEntityFrameworkSqlServer()
                .AddDbContext<SistemaTarefaDB>(
                    opotions => opotions.UseSqlServer(builder.Configuration.GetConnectionString("DataBase"))
                );

            builder.Services.AddScoped<UiUsuario, UsuarioRepo>();
            #endregion
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}