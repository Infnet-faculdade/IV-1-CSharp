using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2
{
    class Exercicio8
    {
        public void Start()
        {
            Console.Write("Digite uma nota de 0 a 10: ");
            double nota = LerNotaValida();

            // Classificação da nota
            string classificacao;
            if (nota < 4)
            {
                classificacao = "Insuficiente";
            }
            else if (nota < 6)
            {
                classificacao = "Regular";
            }
            else if (nota < 8)
            {
                classificacao = "Bom";
            }
            else
            {
                classificacao = "Excelente";
            }

            Console.WriteLine($"A nota {nota} é classificada como: {classificacao}");
        }

        static double LerNotaValida()
        {
            double nota;
            while (!double.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 10)
            {
                Console.Write("Entrada inválida! Digite uma nota entre 0 e 10: ");
            }
            return nota;
        }
    }
}
