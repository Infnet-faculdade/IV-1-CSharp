using System;
using System.IO;

namespace AT
{
    class Exercicio11
    {
        // Caminho do arquivo onde os contatos serão armazenados
        static string caminhoArquivo = "contatos.txt";

        static void Executar(string[] args)
        {
            int opcao;
            do
            {
                ExibirMenu();

                // Ler a opção escolhida
                Console.Write("Escolha uma opção: ");
                while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 3)
                {
                    Console.WriteLine("Opção inválida! Por favor, escolha uma opção entre 1 e 3.");
                    Console.Write("Escolha uma opção: ");
                }

                switch (opcao)
                {
                    case 1:
                        AdicionarContato();
                        break;

                    case 2:
                        ListarContatos();
                        break;

                    case 3:
                        Console.WriteLine("Encerrando programa...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

            } while (opcao != 3);
        }

        // Método para exibir o menu
        static void ExibirMenu()
        {
            Console.Clear();
            Console.WriteLine("=== Gerenciador de Contatos ===");
            Console.WriteLine("1 - Adicionar novo contato");
            Console.WriteLine("2 - Listar contatos cadastrados");
            Console.WriteLine("3 - Sair");
        }

        // Método para adicionar um novo contato
        static void AdicionarContato()
        {
            Console.Clear();
            Console.WriteLine("Adicionar Novo Contato");

            // Solicitar os dados do contato
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            // Salvar no arquivo
            try
            {
                using (StreamWriter writer = new StreamWriter(caminhoArquivo, true))
                {
                    writer.WriteLine($"{nome},{telefone},{email}");
                }

                Console.WriteLine("Contato cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar o contato: {ex.Message}");
            }

            // Aguardar o usuário pressionar uma tecla para voltar ao menu
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        // Método para listar os contatos cadastrados
        static void ListarContatos()
        {
            Console.Clear();
            Console.WriteLine("Contatos cadastrados:");

            // Verificar se o arquivo existe
            if (!File.Exists(caminhoArquivo))
            {
                Console.WriteLine("Nenhum contato cadastrado.");
            }
            else
            {
                try
                {
                    // Ler o arquivo e exibir os contatos
                    string[] contatos = File.ReadAllLines(caminhoArquivo);

                    if (contatos.Length == 0)
                    {
                        Console.WriteLine("Nenhum contato cadastrado.");
                    }
                    else
                    {
                        foreach (var contato in contatos)
                        {
                            string[] dadosContato = contato.Split(',');

                            Console.WriteLine($"Nome: {dadosContato[0]} | Telefone: {dadosContato[1]} | Email: {dadosContato[2]}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao ler os contatos: {ex.Message}");
                }
            }

            // Aguardar o usuário pressionar uma tecla para voltar ao menu
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }
    }
}
