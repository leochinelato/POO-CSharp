using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _13Abstracao
{
    public class PessoaJuridica : Padrao
    {
        // Usar metodo obrigatório
        public override void TaxaEmprestimo(double valor)
        {
            Console.WriteLine($"Taxa de emprestimo para Pessoa Jurídica (PJ) R${valor * 0.05}");
        }
    }
}