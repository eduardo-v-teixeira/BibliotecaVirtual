

using BibliotecaVirtual.Dominio;

namespace BibliotecaVirtual.Servicos
{
    internal class BibliotecaService
    {
        private List<Livro> livros = new List<Livro>();

        public void CadastrarLivros(string titulo, string autor, int ano)
        {
            if (livros.Any(l => l.Titulo.ToLower() == titulo.ToLower()))
            {
                Console.WriteLine("Livro já cadastrado.");
                return;
            }

            livros.Add(new Livro(titulo, autor, ano));
            Console.WriteLine("Livro cadastrado com sucesso!");
        }

        public void ListarLivros()
        {
            if (!livros.Any())
            {
                Console.WriteLine("Nenhum livro cadastrado.");
                return;
            }

            foreach (var livros in livros)
            {
                Console.WriteLine(livros);
            }
        }

        public void PesquisarPorTitulo(string titulo)
        {
            var resultado = livros
                .Where(l => l.Titulo.ToLower().Contains(titulo.ToLower()))
                .ToList();
            if (!resultado)

        }






    }
}
