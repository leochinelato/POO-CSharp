using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _10Heranca
{
    public class Colaborador : Pessoa
    {
        // Atributos
        private double salario;
        
        // Construtor
        public Colaborador(string nome, int idade, double salario)
        {
            this.nome = nome;
            this.idade = idade;
            this.salario = salario;

            MensagemPessoa();
            MensagemColaborador();
        }

        // Método
        private void MensagemColaborador()
        {
            Console.WriteLine($"Nome: {salario}");
        }
    }
}