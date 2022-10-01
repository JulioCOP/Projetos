using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaPedidos.Entities
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        // Contrutor padrão da classe
        public Produto()
        {
        }

        // Contrutor que rece a variavel como argumento
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
        public override string ToString()
        {
            return Nome + Preco;
        }
    }
}
