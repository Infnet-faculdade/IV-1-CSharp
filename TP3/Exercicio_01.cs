using System;

namespace TP3
{
    public class Exercicio_01
    {
        public void Start()
        {
            Carro meuCarro = new Carro("Toyota");
            meuCarro.Acelerar(20);
            meuCarro.Acelerar(15);

            Console.ReadLine(); // Impede que o programa feche imediatamente
        }
    }

    class Carro
    {
        // Campos (Atributos)
        public string Marca;
        public int Velocidade;

        // Construtor da classe
        public Carro(string marca)
        {
            Marca = marca;
            Velocidade = 0; // Começa parado
        }

        // Método para acelerar o carro
        public void Acelerar(int incremento)
        {
            Velocidade += incremento;
            Console.WriteLine($"O carro {Marca} agora está a {Velocidade} km/h.");
        }
    }
}