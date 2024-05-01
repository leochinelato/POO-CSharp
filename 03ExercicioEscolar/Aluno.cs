using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03ExercicioEscolar
{
    public class Aluno
    {
        // Atributos
        public string nome;
        public double nota1, nota2;

        // Média
        public double Media()
        {
            return (nota1 + nota2) / 2;
        }

        // Situação
        public string Situacao(double media)
        {
            return media >= 7 ? "Aprovado" : "Reprovado";
        }

        // Mensagem
        public void Mensagem()
        {
            double obterMedia = Media();
            string obterSituacao = Situacao(obterMedia);
            Console.WriteLine($"{nome} está {obterSituacao}, com média: {obterMedia}");
        }
    }
}