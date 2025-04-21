using System;

class Exercicio4
{
    public void Executar()
    {
        // Solicita a data de nascimento ao usuário
        Console.Write("Digite sua data de nascimento (dd/mm/aaaa): ");
        string inputData = Console.ReadLine();

        // Converte a string para o formato DateTime
        DateTime dataNascimento;
        if (DateTime.TryParseExact(inputData, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataNascimento))
        {
            // Obtém a data de hoje
            DateTime hoje = DateTime.Today;

            // Calcula o próximo aniversário
            DateTime proximoAniversario = new DateTime(hoje.Year, dataNascimento.Month, dataNascimento.Day);

            // Se o aniversário já passou neste ano, ajusta para o próximo ano
            if (proximoAniversario < hoje)
            {
                proximoAniversario = proximoAniversario.AddYears(1);
            }

            // Calcula a diferença de dias
            int diasFaltando = (proximoAniversario - hoje).Days;

            // Exibe a quantidade de dias restantes até o próximo aniversário
            Console.WriteLine($"Faltam {diasFaltando} dias para o seu próximo aniversário.");

            // Exibe mensagem especial se faltar menos de 7 dias
            if (diasFaltando < 7)
            {
                Console.WriteLine("Uau, seu aniversário está chegando! Prepare-se!");
            }
        }
        else
        {
            Console.WriteLine("Data inválida. Tente novamente com o formato correto (dd/mm/aaaa).");
        }
    }
}

