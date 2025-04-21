using System;

class Exercicio3
{
    public void Executar()
    {
        Console.WriteLine("Bem-vindo à Calculadora!");

        // Solicita o primeiro número
        double numero1 = LerNumero("Digite o primeiro número: ");

        // Solicita o segundo número
        double numero2 = LerNumero("Digite o segundo número: ");

        // Exibe as opções de operação
        Console.WriteLine("\nEscolha uma operação:");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");

        // Solicita a escolha da operação
        int escolha = LerOperacao("\nDigite o número da operação desejada: ");

        // Realiza a operação escolhida
        double resultado = Calcular(numero1, numero2, escolha);

        // Exibe o resultado
        Console.WriteLine($"\nResultado: {resultado}");
    }

    // Método para validar a entrada de números
    static double LerNumero(string mensagem)
    {
        double numero;
        while (true)
        {
            Console.Write(mensagem);
            if (double.TryParse(Console.ReadLine(), out numero))
            {
                return numero;
            }
            Console.WriteLine("Entrada inválida! Digite um número válido.");
        }
    }

    // Método para validar a escolha da operação
    static int LerOperacao(string mensagem)
    {
        int operacao;
        while (true)
        {
            Console.Write(mensagem);
            if (int.TryParse(Console.ReadLine(), out operacao) && operacao >= 1 && operacao <= 4)
            {
                return operacao;
            }
            Console.WriteLine("Escolha inválida! Digite 1, 2, 3 ou 4.");
        }
    }

    // Método para realizar o cálculo
    static double Calcular(double num1, double num2, int operacao)
    {
        switch (operacao)
        {
            case 1:
                return num1 + num2;
            case 2:
                return num1 - num2;
            case 3:
                return num1 * num2;
            case 4:
                return num2 != 0 ? num1 / num2 : throw new DivideByZeroException("Erro: Divisão por zero!");
            default:
                throw new ArgumentException("Operação inválida.");
        }
    }
}
