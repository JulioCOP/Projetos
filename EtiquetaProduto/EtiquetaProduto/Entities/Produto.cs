using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EtiquetaProduto.Entities
{
    internal class Produto 
    {
        public string Nome { get; set; }
        public double Preco { get; set; }   

        // Construtor padrão, caso seja necessário adicionar mais classe futuramente
        public Produto()
        {

        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        // Permite que essa função seja herdada por outras classes
        public virtual string tagPreco()
        {
            return Nome + "R$" + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
