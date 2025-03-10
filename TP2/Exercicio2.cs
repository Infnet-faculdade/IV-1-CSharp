using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2
{
    class Exercicio2
    {
        public void Start()
        {
            Console.Write("Digite sua data de nascimento (dd/mm/aaaa): ");
            DateTime dataNascimento;

            while (!DateTime.TryParse(Console.ReadLine(), out dataNascimento))
            {
                Console.Write("Formato inválido! Digite novamente (dd/mm/aaaa): ");
            }

            DateTime hoje = DateTime.Today;

            DateTime proximoAniversario = new DateTime(hoje.Year, dataNascimento.Month, dataNascimento.Day);

            if (proximoAniversario < hoje)
            {
                proximoAniversario = proximoAniversario.AddYears(1);
            }

            int diasFaltando = (proximoAniversario - hoje).Days;

            Console.WriteLine($"Faltam {diasFaltando} dias para o seu próximo aniversário!");
        }
    }

}
