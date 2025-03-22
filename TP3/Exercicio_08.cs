using System; // Importando o namespace necessário

public class Exercicio_08
{
    // Propriedades da matrícula
    public string NomeDoAluno { get; set; }
    public string Curso { get; set; }
    public int NumeroMatricula { get; set; }
    public string Situacao { get; set; }
    public string DataInicial { get; set; }

    // Construtor
    public Exercicio_08(string nomeDoAluno, string curso, int numeroMatricula, string situacao, string dataInicial)
    {
        NomeDoAluno = nomeDoAluno;
        Curso = curso;
        NumeroMatricula = numeroMatricula;
        Situacao = situacao;
        DataInicial = dataInicial;
    }

    // Método para trancar a matrícula
    public void Trancar()
    {
        Situacao = "Trancada";
    }

    // Método para reativar a matrícula
    public void Reativar()
    {
        Situacao = "Ativa";
    }

    // Método para exibir as informações da matrícula
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome do Aluno: {NomeDoAluno}");
        Console.WriteLine($"Curso: {Curso}");
        Console.WriteLine($"Número da Matrícula: {NumeroMatricula}");
        Console.WriteLine($"Situação: {Situacao}");
        Console.WriteLine($"Data Inicial: {DataInicial}");
    }
}
