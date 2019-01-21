using Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using Switch.Domain.Entities;
using Switch.Infra.Data.Config;
using Switch.Infra.Data.Context;
using System;
using System.Linq;

namespace SwitchAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = NovoUsuario("3");

            var optionBuilder = new DbContextOptionsBuilder<SwitchContext>().EnableSensitiveDataLogging();
            optionBuilder.UseLazyLoadingProxies();
            optionBuilder
                .UseMySql("Server=localhost;userid=root;Database=SwitchDB", m => m.MigrationsAssembly("Switch.Infra.Data"));

            try
            {
                using (var contexto = new SwitchContext(optionBuilder.Options))
                {
                    contexto.GetService<ILoggerFactory>().AddProvider(new Logger());

                    var resultado = contexto.Usuarios.ToList();
                    

                    //Console.WriteLine("Usuário add com sucesso!");
                    Console.ReadKey();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }

        private static Usuario NovoUsuario(string valor)
        {
            return new Usuario
            {
                Nome = "Usuario"+valor,
                Email = "Email"+valor,
                DataNascimento = new DateTime(2002, 2, 5),
                SobreNome = "Sobrenome "+valor,
                Senha = "senha"+valor
            };
        }
    }
}
