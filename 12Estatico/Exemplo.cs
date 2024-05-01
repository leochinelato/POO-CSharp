using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _12Estatico
{
    public class Exemplo
    {

        // Atributo estatico
        public static string nome = "Leo";
        
        public static void Soma(int n1, int n2)
        {
            Console.WriteLine(n1+n2);
        }
    }
}