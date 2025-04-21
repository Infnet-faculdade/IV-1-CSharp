using System;
using System.IO;

namespace AT
{
    // Classe Produto
    public class Exercicio9
    {
        static string caminhoArquivo = "estoque.txt";

        // Método Executar corrigido, com tipo de retorno 'void'
        public void Executar()
        {
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
                    Console.Write("Digite o nome do produto: ");
                    string nome = Console.ReadLine();

                    Console.Write("Digite a quantidade em estoque: ");
                    int quantidade = int.Parse(Console.ReadLine());

                    Console.Write("Digite o preço unitário: ");
                    decimal precoUnitario = decimal.Parse(Console.ReadLine());

                    // Criando o objeto Produto
                    Produto produto = new Produto(nome, quantidade, precoUnitario);

                    // Salva o produto no arquivo
                    using (StreamWriter sw = new StreamWriter(caminhoArquivo, true))
                    {
                        sw.WriteLine(produto.ToString());  // Escreve o produto no arquivo
                    }

                    Console.WriteLine("Produto inserido com sucesso!");
                }
                else if (opcao == "2")
                {
                    // Listar Produtos
                    if (File.Exists(caminhoArquivo))
                    {
                        string[] linhas = File.ReadAllLines(caminhoArquivo);

                        if (linhas.Length == 0)
                        {
                            Console.WriteLine("Nenhum produto cadastrado.");
                        }
                        else
                        {
                            foreach (var linha in linhas)
                            {
                                var dados = linha.Split(',');
                                string nome = dados[0];
                                int quantidade = int.Parse(dados[1]);
                                decimal precoUnitario = decimal.Parse(dados[2]);

                                Console.WriteLine($"Produto: {nome} | Quantidade: {quantidade} | Preço: R$ {precoUnitario:F2}");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nenhum produto cadastrado.");
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
