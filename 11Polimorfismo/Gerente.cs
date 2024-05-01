using System;
using System.Collections.Generic;
using System.Configuration.Assemblies;
using System.Linq;
using System.Threading.Tasks;

namespace _11Polimorfismo
{
    public class Gerente : Imposto
    {
        // Metodo
        public override void ValeAlimentacao(double salario)
        {
            Console.WriteLine($"Desconto gerente do vale alimentacao: R${salario * 0.15}");
        }
    }
}