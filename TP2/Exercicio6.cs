using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2
{
    class Exercicio6
    {
        public void Start()
        {
            Console.Write("Digite seu peso (kg): ");
            double peso = LerDoubleValido();

            Console.Write("Digite sua altura (m): ");
            double altura = LerDoubleValido();

            double imc = peso / (altura * altura);

            string classificacao = ClassificarIMC(imc);

            Console.WriteLine("\n===== RESULTADO DO IMC =====");
            Console.WriteLine($"Seu IMC: {imc:F2}");
            Console.WriteLine($"Classificação: {classificacao}");
            Console.WriteLine("============================");
        }

        static double LerDoubleValido()
        {
            double numero;
            while (!double.TryParse(Console.ReadLine(), out numero) || numero <= 0)
            {
                Console.Write("Entrada inválida! Digite um número positivo: ");
            }
            return numero;
        }

        static string ClassificarIMC(double imc)
        {
            if (imc < 18.5) return "Abaixo do peso";
            else if (imc < 24.9) return "Peso normal";
            else if (imc < 29.9) return "Sobrepeso";
            else if (imc < 34.9) return "Obesidade Grau I";
            else if (imc < 39.9) return "Obesidade Grau II";
            else return "Obesidade Grau III (mórbida)";
        }
    }
}
