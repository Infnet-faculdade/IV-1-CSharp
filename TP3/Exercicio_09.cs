using System;

namespace TP3
{
    public class Exercicio_09
    {
        public string NomeDoAluno { get; set; }
        public string Curso { get; set; }
        public int NumeroMatricula { get; set; }
        public string Situacao { get; set; }
        public string DataInicial { get; set; }

        public Exercicio_09(string nome, string curso, int numero, string situacao, string data)
        {
            NomeDoAluno = nome;
            Curso = curso;
            NumeroMatricula = numero;
            Situacao = situacao;
            DataInicial = data;
        }

        public void Trancar()
        {
            Situacao = "Trancada";
        }

        public void Reativar()
        {
            Situacao = "Ativa";
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome do Aluno: {NomeDoAluno}");
            Console.WriteLine($"Curso: {Curso}");
            Console.WriteLine($"Número da Matrícula: {NumeroMatricula}");
            Console.WriteLine($"Situação: {Situacao}");
            Console.WriteLine($"Data Inicial: {DataInicial}");
        }

        public void Start()
        {
            ExibirInformacoes();
            Trancar();
            Console.WriteLine("\nApós trancar a matrícula:");
            ExibirInformacoes();
        }
    }
}
