using System;

namespace TP3
{
    public class TestaFiguras
    {
        public static void Main(string[] args)
        {
            // Instanciando os objetos
            var circulo = new Circulo { Raio = 3.0 };  // Definindo Raio para o círculo
            var esfera = new Esfera { Raio = 5.0 };    // Definindo Raio para a esfera

            // Calculando e exibindo os resultados
            Console.WriteLine("Área do Círculo: " + circulo.CalcularArea());
            Console.WriteLine("Volume da Esfera: " + esfera.CalcularVolume());
        }
    }
}
