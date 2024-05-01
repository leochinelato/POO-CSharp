using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11Polimorfismo
{
    public class Imposto
    {
        // Métodos
        public virtual void ValeAlimentacao(double salario)
        {
            Console.WriteLine($"Desconto do vale alimentacao: R${salario * 0.1}");
        }

        public void ValeTransporte(double salario)
        {
            Console.WriteLine($"Desconto do vale transporte: R${salario * 0.06}");
        }
    }
}