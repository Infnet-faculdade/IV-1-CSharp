using AT;
using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Escolha um exercício para executar (1 a 12) ou digite 0 para sair:");
            if (int.TryParse(Console.ReadLine(), out int escolha))
            {
                if (escolha == 0)
                {
                    Console.WriteLine("Saindo do programa...");
                    break;
                }

                switch (escolha)
                {
                    case 1: new Exercicio1().Executar(); break;
                    case 2: new Exercicio2().Executar(); break;
                    case 3: new Exercicio3().Executar(); break;
                    case 4: new Exercicio4().Executar(); break;
                    case 5: new Exercicio5().Executar(); break;
                    case 6: new Exercicio6().Executar(); break;
                    case 7: new Exercicio7().Executar(); break;
                    case 8: new Exercicio8().Executar(); break;
                    case 9: new Exercicio9().Executar(); break;
                    case 10: new Exercicio10().Executar(); break;
                    case 11: new Exercicio11().Executar(); break;
                    case 12: new Exercicio12().Executar(); break;
                    default: Console.WriteLine("Opção inválida. Tente novamente."); break;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Digite um número de 1 a 12.");
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
