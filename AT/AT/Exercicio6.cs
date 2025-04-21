using System;

namespace AT
{
    public class Exercicio6
    {
        public void Executar()
        {
            // Criação do objeto Aluno com seus dados
            Aluno aluno = new Aluno
            {
                Nome = "Seu Nome",
                Matricula = "123456",
                Curso = "Engenharia de Software",
                MediaNotas = 8.5
            };

            // Exibe os dados do aluno
            aluno.ExibirDados();

            // Verifica a aprovação do aluno
            string status = aluno.VerificarAprovacao();
            Console.WriteLine($"Status de Aprovação: {status}");
        }
    }

    public class Aluno
    {
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public string Curso { get; set; }
        public double MediaNotas { get; set; }

        // Exibe os dados do aluno
        public void ExibirDados()
        {
            Console.WriteLine("----- Dados do Aluno -----");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Matrícula: {Matricula}");
            Console.WriteLine($"Curso: {Curso}");
            Console.WriteLine($"Média das Notas: {MediaNotas:F2}");
            Console.WriteLine("--------------------------");
        }

        // Verifica a aprovação do aluno
        public string VerificarAprovacao()
        {
            if (MediaNotas >= 7)
                return "Aprovado";
            else
                return "Reprovado";
        }
    }
}
