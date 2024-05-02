using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerBiblioteca
{
    public class Cliente
    {
        private List<Livro> emprestimos = [];
        public string nome;
        public string id;

        public Cliente(string nome, string id)
        {
            this.nome = nome;
            this.id = id;
        }

        public void AdicionarEmprestimo(Livro livro)
        {
            emprestimos.Add(livro);
        }

        public bool RemoverEmprestimo(Livro livro)
        {
            return emprestimos.Remove(livro);
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Nome: {this.nome}");
            Console.WriteLine($"ID: {this.id}");

        }

    }
}