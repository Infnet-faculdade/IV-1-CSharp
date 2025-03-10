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
            Console.Write("Digite um n�mero inteiro: ");
            int numero = LerInteiroValido();

            if (numero % 2 == 0)
            {
                Console.WriteLine($"O n�mero {numero} � PAR.");
            }
            else
            {
                Console.WriteLine($"O n�mero {numero} � �MPAR.");
            }
        }

        static int LerInteiroValido()
        {
            int numero;
            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.Write("Entrada inv�lida! Digite um n�mero inteiro v�lido: ");
            }
            return numero;
        }
    }
}
