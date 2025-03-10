using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2
{
    class Exercicio9
    {
        public void Start()
        {
            Console.Write("Digite seu sal�rio bruto: R$ ");
            double salarioBruto = LerSalarioValido();

            double desconto = CalcularDesconto(salarioBruto);
            double salarioLiquido = salarioBruto - desconto;

            Console.WriteLine($"\nSal�rio Bruto: R$ {salarioBruto:F2}");
            Console.WriteLine($"Desconto de Imposto: R$ {desconto:F2}");
            Console.WriteLine($"Sal�rio L�quido: R$ {salarioLiquido:F2}");
        }

        static double LerSalarioValido()
        {
            double salario;
            while (!double.TryParse(Console.ReadLine(), out salario) || salario <= 0)
            {
                Console.Write("Entrada inv�lida! Digite um sal�rio v�lido: R$ ");
            }
            return salario;
        }

        static double CalcularDesconto(double salarioBruto)
        {
            double desconto = 0;

            if (salarioBruto <= 2000)
            {
                desconto = salarioBruto * 0.05; 
            }
            else if (salarioBruto <= 5000)
            {
                desconto = salarioBruto * 0.10; 
            }
            else
            {
                desconto = salarioBruto * 0.15; 
            }

            return desconto;
        }
    }
}
