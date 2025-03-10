using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2
{
    class Exercicio10
    {
        public void Start()
        {
            
            Console.Write("Digite um número para iniciar a contagem regressiva: ");
            int numero = LerNumeroValido();

           
            for (int i = numero; i >= 0; i--)
            {
                
                if (i > 0)
                {
                    Console.Write(i + ", ");
                }
                else
                {
                    Console.Write(i);
                }
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
