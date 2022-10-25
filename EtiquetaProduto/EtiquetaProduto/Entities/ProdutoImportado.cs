using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EtiquetaProduto.Entities
{
    internal class ProdutoImportado : Produto
    {
        public double CustoDeTaxa { get; set; }
    // Contrutor padrão 
        public ProdutoImportado()
        {

        }

        public ProdutoImportado(string nome, double preco, double custoDeTaxa): base(nome, preco)
        {
            CustoDeTaxa = custoDeTaxa;
        }
        public double PrecoFinal()
        {
            return Preco + CustoDeTaxa;
        }
        public override string tagPreco()
        {
            return Nome + "R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + " -> " + "Taxa de custo da alfândega R$: " + CustoDeTaxa.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
    
}
