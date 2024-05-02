using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerBiblioteca
{
    public class Livro
    {
        public string titulo;
        public string autor;
        public string genero;
        public int numeroPaginas;

        public bool Emprestado { get; private set; }

        public Livro()
        {
            this.titulo = "";
            this.autor = "";
            this.genero = "";
            this.numeroPaginas = 0;
        }

        public Livro(string titulo, string autor, string genero, int numeroPaginas)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.genero = genero;
            this.numeroPaginas = numeroPaginas;

            Emprestado = false;
        }

        public void MarcarComoEmprestado()
        {
            Emprestado = true;
        }

        public void MarcarComoDevolvido()
        {
            Emprestado = false;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Titulo: {this.titulo}");
            Console.WriteLine($"Autor: {this.autor}");
            Console.WriteLine($"Genero: {this.genero}");
            Console.WriteLine($"Número de Páginas: {this.numeroPaginas}");
        }
    }
}