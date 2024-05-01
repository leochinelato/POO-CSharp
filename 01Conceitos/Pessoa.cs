using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01Conceitos
{
    public class Pessoa
    {
        // Atributo
        public string nome;
        public int idade;

        public void mensagem()
        {
            Console.WriteLine($"Olá {nome}, você tem {idade} anos.");
        }
    }
}