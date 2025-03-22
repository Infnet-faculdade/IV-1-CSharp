using System; // Adicione esta linha para poder usar o Console

public class Exercicio_03
{
    public string nomeDoShow;
    public double preco;
    public int quantidadeDisponivel;

    // Método para alterar o preço
    public void AlterarPreco(double novoPreco)
    {
        preco = novoPreco;
    }

    // Método para alterar a quantidade disponível
    public void AlterarQuantidade(int novaQuantidade)
    {
        quantidadeDisponivel = novaQuantidade;
    }

    // Método para exibir as informações
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome do Show: {nomeDoShow}");
        Console.WriteLine($"Preço: R${preco}");
        Console.WriteLine($"Quantidade Disponível: {quantidadeDisponivel} ingressos");
    }
}
