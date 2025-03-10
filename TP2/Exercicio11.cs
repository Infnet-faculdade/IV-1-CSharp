using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2
{
    class Exercicio11
    {
        public void Start()
        {
            Console.Write("Digite um número para ver sua tabuada: ");
            int numero = LerNumeroValido();

            Console.WriteLine($"Tabuada de {numero}:");
            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
            }
        }

        static int LerNumeroValido()
        {
            int numero;
            while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
            {
                Console.Write("Entrada inválida! Digite um número válido: ");
            }
            return numero;
        }
    }
}
