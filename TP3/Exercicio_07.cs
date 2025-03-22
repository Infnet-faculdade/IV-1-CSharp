using System;

public class Exercicio_07
{
    public string NomeDoAluno { get; set; }
    public string Curso { get; set; }
    public int NumeroMatricula { get; set; }
    public string Situacao { get; set; }
    public string DataInicial { get; set; }

    // Construtor para inicializar os atributos
    public Exercicio_07(string nomeDoAluno, string curso, int numeroMatricula, string situacao, string dataInicial)
    {
        NomeDoAluno = nomeDoAluno;
        Curso = curso;
        NumeroMatricula = numeroMatricula;
        Situacao = situacao;
        DataInicial = dataInicial;
    }
}
