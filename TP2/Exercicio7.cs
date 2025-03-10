using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2
{
    class Exercicio7
    {
        public void Start()
        {
            Console.Write("Digite um número inteiro: ");
            int numero = LerInteiroValido();

            if (numero % 2 == 0)
            {
                Console.WriteLine($"O número {numero} é PAR.");
            }
            else
            {
                Console.WriteLine($"O número {numero} é ÍMPAR.");
            }
        }

        static int LerInteiroValido()
        {
            int numero;
            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.Write("Entrada inválida! Digite um número inteiro válido: ");
            }
            return numero;
        }
    }
}
