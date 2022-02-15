using Injecao_dependencia.Interfaces;

namespace Injecao_dependencia.Service
{
    public class ProdutoService : IProdutoService
    {
        private readonly ICategoriaService _categoria;

        public ProdutoService(ICategoriaService categoria)
        {
            _categoria = categoria;
        }

        public string ConsoleProduto()
        {
            _categoria.ConsoleCategoria();

            return "Olá, eu sou uma aplicação console.";
        }
    }
}