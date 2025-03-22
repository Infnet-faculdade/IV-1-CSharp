using System; // Importando o namespace necessário

public class Exercicio_06
{
    private string nomeDoShow;
    private double preco;
    private int quantidadeDisponivel;

    // Construtor
    public Exercicio_06(string nomeDoShow, double preco, int quantidadeDisponivel)
    {
        this.nomeDoShow = nomeDoShow;
        this.preco = preco;
        this.quantidadeDisponivel = quantidadeDisponivel;
    }

    // Exibir informações
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome do Show: {nomeDoShow}");
        Console.WriteLine($"Preço: R${preco}");
        Console.WriteLine($"Quantidade Disponível: {quantidadeDisponivel} ingressos");
    }
}
