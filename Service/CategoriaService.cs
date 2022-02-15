using Injecao_dependencia.Interfaces;

namespace Injecao_dependencia.Service
{
    public class CategoriaService : ICategoriaService
    {
        public void ConsoleCategoria()
        {
            Console.WriteLine("Console da categoria.");
        }
    }
}