using System;

public class Exercicio_04
{
    public void Executar()
    {
        // Instanciando o ingresso
        Exercicio_03 ingresso = new Exercicio_03();
        ingresso.nomeDoShow = "Show da Banda X";
        ingresso.preco = 150.0;
        ingresso.quantidadeDisponivel = 500;

        // Exibindo informações iniciais
        ingresso.ExibirInformacoes();

        // Alterando preço e quantidade
        ingresso.AlterarPreco(180.0);
        ingresso.AlterarQuantidade(400);

        // Exibindo as informações após alteração
        ingresso.ExibirInformacoes();
    }
}
