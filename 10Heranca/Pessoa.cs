using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _10Heranca
{
    public class Pessoa
    {
        // Atributos
        protected string nome;
        protected int idade;

        // Método
        protected void MensagemPessoa()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
        }
    }
}