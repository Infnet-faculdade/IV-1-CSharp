using System;

namespace AT
{
    // Classe base Funcionario
    public class Funcionario
    {
        // Atributos
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public decimal SalarioBase { get; set; }

        // Construtor
        public Funcionario(string nome, string cargo, decimal salarioBase)
        {
            Nome = nome;
            Cargo = cargo;
            SalarioBase = salarioBase;
        }

        // Método para exibir o salário base
        public virtual void ExibirSalario()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Cargo: {Cargo}");
            Console.WriteLine($"Salário Base: R$ {SalarioBase:F2}");
        }
    }

    // Subclasse Gerente, herda de Funcionario
    public class Gerente : Funcionario
    {
        // Construtor
        public Gerente(string nome, string cargo, decimal salarioBase)
            : base(nome, cargo, salarioBase)
        {
        }

        // Sobrescrita do método ExibirSalario para incluir o bônus de 20%
        public override void ExibirSalario()
        {
            decimal salarioComBonus = SalarioBase * 1.2M;
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Cargo: {Cargo}");
            Console.WriteLine($"Salário Base: R$ {SalarioBase:F2}");
            Console.WriteLine($"Salário com Bônus de 20%: R$ {salarioComBonus:F2}");
        }
    }
}
