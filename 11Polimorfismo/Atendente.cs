using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11Polimorfismo
{
    public class Atendente : Imposto
    {
        // Método
        public override void ValeAlimentacao(double salario)
        {
            Console.WriteLine($"Desconto atendente do vale alimentacao: R${salario * 0.12}");
        }

    }
}