using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _07Construtor
{
    public class Pessoa
    {
        public Pessoa()
        {
            // Construtor
            Console.WriteLine("Construtor Executado");

        }

        public Pessoa(string nome)
        {
            Console.WriteLine($"Olá {nome}");
        }
    }
}