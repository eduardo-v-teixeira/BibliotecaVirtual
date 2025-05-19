using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Dominio
{
    public class Livro
    {
        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public int Ano { get; private set; }
        public bool Emprestado { get; private set; }

        public Livro(string titulo, string autor, int ano)
        {
            Titulo = titulo;
            Autor = autor;
            Ano = ano;
            Emprestado = true;
        }

        public void Emprestar()
        {
            Emprestado = false;
        }

        public void Devolver()
        {
            Emprestado = false;
        }

        public override string ToString()
        {
            return $"{Titulo} - {Autor} ({Ano}) | {(Emprestado ? "Emprestado" : "Disponível")}";
        }
    }
}
