using System;

namespace TP3
{
    // Classe Circulo com método para calcular a área
    public class Exercicio_11
    {
        public double Raio { get; set; }

        // Método para calcular a área do círculo (A = π * r²)
        public double CalcularArea()
        {
            return Math.PI * (Raio * Raio); // Fórmula da área do círculo
        }
    }

    // Classe Esfera com método para calcular o volume
    public class Esfera2
    {
        public double Raio { get; set; }

        // Método para calcular o volume da esfera (V = (4/3) * π * r³)
        public double CalcularVolume()
        {
            return (4.0 / 3.0) * Math.PI * (Raio * Raio * Raio); // Fórmula do volume da esfera
        }
    }
}
