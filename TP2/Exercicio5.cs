using System;

namespace Tp2
{
    class Exercicio5
    {
        public void Start()
        {
            Console.Write("Digite a temperatura em Celsius: ");
            if (double.TryParse(Console.ReadLine(), out double celsius))
            {
                double fahrenheit = celsius * 9 / 5 + 32;
                double kelvin = celsius + 273.15;

                Console.WriteLine($"\n🔥 Fahrenheit: {fahrenheit:F2}°F");
                Console.WriteLine($"❄️ Kelvin: {kelvin:F2}K");
            }
            else
            {
                Console.WriteLine("Entrada inválida! Digite um número válido.");
            }
        }
    }
}
