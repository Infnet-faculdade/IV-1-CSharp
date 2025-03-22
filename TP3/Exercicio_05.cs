using System; // Adicionando a importação necessária

public class Exercicio_05
{
    private string nomeDoShow;
    private double preco;
    private int quantidadeDisponivel;

    // Getters
    public string GetNomeDoShow() => nomeDoShow;
    public double GetPreco() => preco;
    public int GetQuantidadeDisponivel() => quantidadeDisponivel;

    // Setters
    public void SetNomeDoShow(string novoNome) => nomeDoShow = novoNome;
    public void SetPreco(double novoPreco) => preco = novoPreco;
    public void SetQuantidadeDisponivel(int novaQuantidade) => quantidadeDisponivel = novaQuantidade;

    // Exibir informações
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome do Show: {nomeDoShow}");
        Console.WriteLine($"Preço: R${preco}");
        Console.WriteLine($"Quantidade Disponível: {quantidadeDisponivel} ingressos");
    }
}

