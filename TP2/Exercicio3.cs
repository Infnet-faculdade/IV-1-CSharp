using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2
{
    class Exercicio3
    {
        public void Start()
        {
            Console.Write("Digite a primeira data (dd/mm/aaaa): ");
            DateTime data1 = LerDataValida();

            Console.Write("Digite a segunda data (dd/mm/aaaa): ");
            DateTime data2 = LerDataValida();

            // Garante que data1 seja sempre a menor para evitar cálculos negativos
            if (data1 > data2)
            {
                (data1, data2) = (data2, data1);
            }

            // Calcula a diferença total em dias
            TimeSpan diferencaDias = data2 - data1;

            // Calcula a diferença em anos, meses e dias
            int anos = data2.Year - data1.Year;
            int meses = data2.Month - data1.Month;
            int dias = data2.Day - data1.Day;

            // Ajusta se necessário (caso os meses ou dias fiquem negativos)
            if (dias < 0)
            {
                meses--;
                dias += DateTime.DaysInMonth(data2.Year, data2.AddMonths(-1).Month);
            }

            if (meses < 0)
            {
                anos--;
                meses += 12;
            }

            Console.WriteLine($"Diferença entre as datas: {anos} anos, {meses} meses e {dias} dias.");
            Console.WriteLine($"Total de dias: {diferencaDias.Days}");
        }

        static DateTime LerDataValida()
        {
            DateTime data;
            while (!DateTime.TryParse(Console.ReadLine(), out data))
            {
                Console.Write("Formato inválido! Digite novamente (dd/mm/aaaa): ");
            }
            return data;
        }
    }

}

