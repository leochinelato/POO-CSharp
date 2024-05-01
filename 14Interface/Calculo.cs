using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _14Interface
{
    public class Calculo : IPadrao
    {
        public void Somar(int n1, int n2)
        {
            Console.WriteLine($"A soma entre {n1} e {n2} é {n1 + n2}");
        }

        public void Subtrair(int n1, int n2)
        {
            Console.WriteLine($"A subtração entre {n1} e {n2} é {n1-n2}");
        }
    }
}