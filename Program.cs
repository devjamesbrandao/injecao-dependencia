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

            Console.WriteLine(ProdutoComInjecaoDependencia(host.Services));

            return host.RunAsync();
        }

        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
            .ConfigureServices((_, services) => 
                services.AddTransient<IProdutoService, ProdutoService>()
                .AddTransient<ICategoriaService, CategoriaService>()
            );
        }

        public static string ProdutoComInjecaoDependencia(IServiceProvider services)
        {
            using var serviceScope = services.CreateScope();

            var provider = serviceScope.ServiceProvider;

            var produto = provider.GetRequiredService<IProdutoService>();

            return produto.ConsoleProduto();
        }
    }
}
