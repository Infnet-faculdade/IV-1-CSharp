using System;

namespace AT
{
    class Exercicio7
    {
        public void Executar()
        {
            // Criando uma nova conta bancária
            ContaBancaria conta = new ContaBancaria("João Silva");

            // Exibindo o titular
            Console.WriteLine($"Titular: {conta.Titular}");

            // Realizando operações
            conta.Depositar(500); // Deposita R$ 500,00
            conta.ExibirSaldo();  // Exibe saldo após o depósito

            // Tentando realizar um saque maior que o saldo
            conta.Sacar(700);     // Saque de R$ 700,00, mas o saldo é insuficiente

            // Realizando um saque de R$ 200,00
            conta.Sacar(200);     // Saque de R$ 200,00
            conta.ExibirSaldo();  // Exibe saldo após o saque
        }
    }
}
