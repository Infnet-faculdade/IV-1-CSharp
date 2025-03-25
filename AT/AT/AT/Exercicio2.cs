using System;

class Exercicio2
{
    public void Executar()
    {
        // Solicita o nome do usuário
        Console.Write("Digite seu nome completo: ");
        string nome = Console.ReadLine();

        // Chama a função para cifrar o nome
        string nomeCifrado = CifrarNome(nome);

        // Exibe o resultado
        Console.WriteLine($"Nome Cifrado: {nomeCifrado}");
    }

    static string CifrarNome(string nome)
    {
        char[] resultado = new char[nome.Length];

        for (int i = 0; i < nome.Length; i++)
        {
            char c = nome[i];

            // Verifica se é uma letra maiúscula
            if (char.IsUpper(c))
            {
                resultado[i] = (char)(((c - 'A' + 2) % 26) + 'A');
            }
            // Verifica se é uma letra minúscula
            else if (char.IsLower(c))
            {
                resultado[i] = (char)(((c - 'a' + 2) % 26) + 'a');
            }
            // Mantém espaços e outros caracteres inalterados
            else
            {
                resultado[i] = c;
            }
        }

        return new string(resultado);
    }
}
