using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaPedidos.Entities
{
    internal class OrdemItem
    {
        public int Quantidade { get; set; }
        public double Preco { get; set; }

        // Construtor padrão
        public OrdemItem()
        {
        }
        //Contrutor que recebe as variaveis do argumento 

        public OrdemItem(int quantidade, double preco)
        {
            Quantidade = quantidade;
            Preco = preco;
        }

        public double Subtotal()
        {
            double totalAPagar = Quantidade * Preco;
            return totalAPagar ;
        }
        public override string ToString()
        {
            return "Quantidade: "+ Quantidade + " Preço: "+ Preco + " Subtotal R$: " + Subtotal().ToString();
        }

    }
}
