using System;

namespace AT
{
    class Exercicio10
    {
        public void Executar()
        {
            // Gerar um número aleatório entre 1 e 50
            Random random = new Random();
            int numeroSecreto = random.Next(1, 51);
            int tentativasRestantes = 5;

            Console.WriteLine("Bem-vindo ao Jogo de Adivinhação!");
            Console.WriteLine("Você deve adivinhar um número entre 1 e 50.");
            Console.WriteLine("Você tem 5 tentativas.");

            // Loop para as tentativas
            while (tentativasRestantes > 0)
            {
                Console.WriteLine($"\nTentativas restantes: {tentativasRestantes}");
                Console.Write("Digite um número: ");
                string entrada = Console.ReadLine();

                // Tratamento de exceção para garantir que o valor inserido seja um número
                try
                {
                    int palpite = int.Parse(entrada);

                    // Verificar se o número está dentro do intervalo permitido
                    if (palpite < 1 || palpite > 50)
                    {
                        Console.WriteLine("Erro! O número deve estar entre 1 e 50.");
                        continue;
                    }

                    // Verificar se o palpite está correto
                    if (palpite == numeroSecreto)
                    {
                        Console.WriteLine("Parabéns! Você acertou o número!");
                        break;
                    }
                    else if (palpite < numeroSecreto)
                    {
                        Console.WriteLine("O número secreto é maior que o seu palpite.");
                    }
                    else
                    {
                        Console.WriteLine("O número secreto é menor que o seu palpite.");
                    }

                    // Reduzir as tentativas restantes
                    tentativasRestantes--;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Erro! Por favor, insira um número válido.");
                }
            }

            // Se o jogador não adivinhar o número nas tentativas, exibir o número correto
            if (tentativasRestantes == 0)
            {
                Console.WriteLine($"\nVocê não acertou o número. O número secreto era {numeroSecreto}.");
            }

            Console.WriteLine("\nFim do Jogo!");
        }
    }
}
