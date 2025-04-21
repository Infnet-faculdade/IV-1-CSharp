using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT
{
    public class Produto
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }

        // Construtor da classe Produto
        public Produto(string nome, int quantidade, decimal precoUnitario)
        {
            Nome = nome;
            Quantidade = quantidade;
            PrecoUnitario = precoUnitario;
        }

        // Método para retornar os dados do produto como string formatada
        public override string ToString()
        {
            return $"{Nome},{Quantidade},{PrecoUnitario:F2}";
        }
    }
}
