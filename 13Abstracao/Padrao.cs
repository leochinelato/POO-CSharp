using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _13Abstracao
{
    public abstract class Padrao
    {
        // Método obrigatório
        public abstract void TaxaEmprestimo(double valor);

        // Método opcional
        public void calculoInvestimento(double valor, double taxa)
        {
            Console.WriteLine($"Ganhos obtidos pelo investimento R${valor*taxa}");
        }
    }
}