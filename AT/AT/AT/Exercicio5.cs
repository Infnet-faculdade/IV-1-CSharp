using System;

class Exercicio5
{
    public void Executar()
    {
        // Defina a data prevista para a formatura
        DateTime dataFormatura = new DateTime(2026, 12, 15);

        // Solicita a data atual ao usuário
        Console.Write("Digite a data atual (dd/MM/yyyy): ");
        string inputData = Console.ReadLine();

        // Converte a string para o formato DateTime
        DateTime dataAtual;
        if (DateTime.TryParseExact(inputData, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataAtual))
        {
            // Verifica se a data atual é no futuro
            if (dataAtual > DateTime.Today)
            {
                Console.WriteLine("Erro: A data informada não pode ser no futuro!");
                return;
            }

            // Se a data de formatura já passou
            if (dataAtual > dataFormatura)
            {
                Console.WriteLine("Parabéns! Você já deveria estar formado!");
                return;
            }

            // Calcula a diferença entre a data de formatura e a data atual
            TimeSpan diferenca = dataFormatura - dataAtual;
            int anosRestantes = dataFormatura.Year - dataAtual.Year;
            int mesesRestantes = dataFormatura.Month - dataAtual.Month;
            int diasRestantes = diferenca.Days;

            // Ajusta os meses e anos corretamente, considerando se o mês de formatura já passou neste ano
            if (mesesRestantes < 0)
            {
                anosRestantes--;
                mesesRestantes += 12;
            }

            // Exibe o tempo restante
            Console.WriteLine($"Faltam {anosRestantes} anos, {mesesRestantes} meses e {diasRestantes} dias para sua formatura!");

            // Exibe mensagem especial se faltar menos de 6 meses
            if (anosRestantes == 0 && mesesRestantes < 6)
            {
                Console.WriteLine("A reta final chegou! Prepare-se para a formatura!");
            }
        }
        else
        {
            Console.WriteLine("Data inválida. Tente novamente com o formato correto (dd/MM/yyyy).");
        }
    }
}
