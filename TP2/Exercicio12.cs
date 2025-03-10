using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2
{
    class Exercicio12
    {
        public void Start()
        {
            Random random = new Random();

            int numeroSecreto = random.Next(1, 101);

            int palpite = 0;

            Console.WriteLine("Tente adivinhar o n�mero secreto entre 1 e 100!");

            while (palpite != numeroSecreto)
            {
                Console.Write("Digite o seu palpite: ");
                palpite = LerNumeroValido();

                if (palpite < numeroSecreto)
                {
                    Console.WriteLine("O n�mero secreto � maior! Tente novamente.");
                }
                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("O n�mero secreto � menor! Tente novamente.");
                }
                else
                {
                    Console.WriteLine($"Parab�ns! Voc� acertou o n�mero {numeroSecreto}.");
                }
            }
        }

        static int LerNumeroValido()
        {
            int numero;
            while (!int.TryParse(Console.ReadLine(), out numero) || numero < 1 || numero > 100)
            {
                Console.Write("Entrada inv�lida! Digite um n�mero v�lido entre 1 e 100: ");
            }
            return numero;
        }
    }
}
