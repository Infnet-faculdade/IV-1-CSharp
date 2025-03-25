using System;

namespace AT
{
    public class ContaBancaria
    {
        // Atributos
        public string Titular { get; set; } // Público para que o titular possa ser acessado diretamente
        private decimal Saldo { get; set; } // Privado para impedir acesso direto

        // Construtor
        public ContaBancaria(string titular)
        {
            Titular = titular;
            Saldo = 0; // Inicializa com saldo 0
        }

        // Método para depositar valor na conta
        public void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor do depósito deve ser positivo!");
                return;
            }
            Saldo += valor;
            Console.WriteLine($"Depósito de R$ {valor:F2} realizado com sucesso!");
        }

        // Método para sacar valor da conta
        public void Sacar(decimal valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque!");
                return;
            }
            Saldo -= valor;
            Console.WriteLine($"Saque de R$ {valor:F2} realizado com sucesso!");
        }

        // Método para exibir o saldo
        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual: R$ {Saldo:F2}");
        }
    }
}
