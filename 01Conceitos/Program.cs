using System;

namespace _01Conceitos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa()
            {
                nome = "Leonardo",
                idade = 20,
            };

            // Outra forma:
            // pessoa1.nome = "Leonardo";
            // pessoa1.idade = 20;

            pessoa1.mensagem();
        }
    }
}