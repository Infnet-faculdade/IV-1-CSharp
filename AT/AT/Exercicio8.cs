using System;

namespace AT
{
    class Exercicio8
    {
        public void Executar()
        {
            // Criando um objeto da classe Funcionario
            Funcionario funcionario = new Funcionario("Carlos Souza", "Desenvolvedor", 4000);

            // Criando um objeto da classe Gerente
            Gerente gerente = new Gerente("Ana Oliveira", "Gerente de TI", 6000);

            // Exibindo os salários
            Console.WriteLine("------ Funcionário ------");
            funcionario.ExibirSalario();  // Exibe salário do funcionário
            Console.WriteLine();

            Console.WriteLine("------ Gerente ------");
            gerente.ExibirSalario();  // Exibe salário do gerente com bônus
        }
    }
}
