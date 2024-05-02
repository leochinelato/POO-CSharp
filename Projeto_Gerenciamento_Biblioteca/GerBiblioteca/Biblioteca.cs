using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerBiblioteca
{
    public class Biblioteca
    {
        public List<Livro> acervoLivros = [];
        public List<Cliente> clientesCadastrados = [];

        public void AdicionarLivro(Livro livro)
        {
            acervoLivros.Add(livro);
            Console.WriteLine($"Livro '{livro.titulo}' adicionado ao acervo da biblioteca.");
        }

        public void CadastrarCliente(Cliente cliente)
        {
            clientesCadastrados.Add(cliente);
            Console.WriteLine($"Cliente [ID: {cliente.id} | NOME: {cliente.nome}] cadastrado com sucesso.");
        }

        public void RealizarEmprestimo(Cliente cliente, Livro livro)
        {
            if (acervoLivros.Contains(livro))
            {
                if (!livro.Emprestado)
                {
                    cliente.AdicionarEmprestimo(livro);
                    livro.MarcarComoEmprestado();
                    Console.WriteLine($"O livro [{livro.titulo}] foi emprestado para: [ID: {cliente.id} | NOME: {cliente.nome}]");
                }
                else
                {
                    Console.WriteLine($"O livro {livro.titulo} já está emprestado.");
                }
            }
            else
            {
                Console.WriteLine($"O livro {livro.titulo} não está disponível na biblioteca.");
            }
        }

        public void RegistrarDevolucao(Cliente cliente, Livro livro)
        {
            if (cliente.RemoverEmprestimo(livro))
            {
                acervoLivros.Add(livro);
                Console.WriteLine($"O livro {livro.titulo} foi devolvido por {cliente.id} {cliente.nome}");
            }
            else
            {
                Console.WriteLine($"O livro {livro.titulo} não está com o {cliente.id} {cliente.nome}");
            }
        }
    }
}