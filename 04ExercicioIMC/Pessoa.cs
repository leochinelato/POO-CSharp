using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _04ExercicioIMC
{
    public class Pessoa
    {
        private double peso;
        private double altura;

        private double CalcularIMC()
        {
            double imc = peso / (altura * altura);
            return imc;
        }

        private string Situacao(double imc)
        {
            string message = "";
            switch (imc)
            {
                case < 18.5:
                    message = "Abaixo do peso";
                    break;
                case < 25:
                    message = "Peso normal";
                    break;
                case < 30:
                    message = "Acima do peso";
                    break;
                case < 35:
                    message = "Obesidade I";
                    break;
                case < 40:
                    message = "Obesidade II";
                    break;
                case >= 40:
                    message = "Obesidade III";
                    break;

            }
            return message;
        }
        public void Mensagem()
        {
            Console.Write("Digite o seu peso: ");
            peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a sua altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            double obterIMC = CalcularIMC();
            string obterSit = Situacao(obterIMC);

            Console.WriteLine($"Você está com {obterSit}, com {obterIMC:.##} de IMC.");

        }
    }
}