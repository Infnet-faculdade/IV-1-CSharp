using System;

namespace AT
{
    public class Produto
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }

        public Produto(string nome, int quantidade, decimal precoUnitario)
        {
            Nome = nome;
            Quantidade = quantidade;
            PrecoUnitario = precoUnitario;
        }
    }

    class ControleEstoqueArray
    {
        static void Main(string[] args)
        {
            Produto[] produtos = new Produto[5];
            int contador = 0;

            while (true)
            {
                // Menu de opções
                Console.Clear();
                Console.WriteLine("1. Inserir Produto");
                Console.WriteLine("2. Listar Produtos");
                Console.WriteLine("3. Sair");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    // Inserir Produto
                    if (contador < 5)
                    {
                        Console.Write("Digite o nome do produto: ");
                        string nome = Console.ReadLine();

                        Console.Write("Digite a quantidade em estoque: ");
                        int quantidade = int.Parse(Console.ReadLine());

                        Console.Write("Digite o preço unitário: ");
                        decimal precoUnitario = decimal.Parse(Console.ReadLine());

                        produtos[contador] = new Produto(nome, quantidade, precoUnitario);
                        contador++;
                        Console.WriteLine("Produto inserido com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Limite de produtos atingido!");
                    }
                }
                else if (opcao == "2")
                {
                    // Listar Produtos
                    if (contador == 0)
                    {
                        Console.WriteLine("Nenhum produto cadastrado.");
                    }
                    else
                    {
                        for (int i = 0; i < contador; i++)
                        {
                            Console.WriteLine($"Produto: {produtos[i].Nome} | Quantidade: {produtos[i].Quantidade} | Preço: R$ {produtos[i].PrecoUnitario:F2}");
                        }
                    }
                }
                else if (opcao == "3")
                {
                    // Sair
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida, tente novamente.");
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}
