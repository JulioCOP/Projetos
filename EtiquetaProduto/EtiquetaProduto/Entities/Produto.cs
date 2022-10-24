using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtiquetaProduto.Entities
{
    internal class Produto : ProdutoImportado
    {
        public string Nome { get; set; }
        public double Preco { get; set; }   

        // Construtor padrã, caso seja necessário adicionar mais classe futuramente
        public Produto()
        {

        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public string tagPreco()
        {
            return Preco.ToString();
        }
    }
}
