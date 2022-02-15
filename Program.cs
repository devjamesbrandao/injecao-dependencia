using Injecao_dependencia.Interfaces;
using Injecao_dependencia.Service;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Injecao_dependencia
{
    public class Program
    {
        public static Task Main(string[] args)
        {
            using var host = CreateHostBuilder(args).Build();
        }

        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
            .ConfigureServices((_, services) => 
                services.AddTransient<IProdutoService, ProdutoService>()
                .AddTransient<ICategoriaService, CategoriaService>()
            );
        }
    }
}
