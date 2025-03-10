using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2
{
    class Exercicio4
    {
        public void Start()
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            int idade = LerInteiroValido();

            Console.Write("Digite seu telefone: ");
            string telefone = Console.ReadLine();

            Console.Write("Digite seu e-mail: ");
            string email = Console.ReadLine();

            Console.WriteLine("\n===== DADOS CADASTRADOS =====");
            Console.WriteLine($"Nome    : {nome}");
            Console.WriteLine($"Idade   : {idade} anos");
            Console.WriteLine($"Telefone: {telefone}");
            Console.WriteLine($"E-mail  : {email}");
            Console.WriteLine("==============================");
        }

        static int LerInteiroValido()
        {
            int numero;
            while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
            {
                Console.Write("Entrada inválida! Digite um número válido para a idade: ");
            }
            return numero;
        }
    }

}

