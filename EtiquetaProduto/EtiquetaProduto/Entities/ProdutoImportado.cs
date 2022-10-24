using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtiquetaProduto.Entities
{
    internal class ProdutoImportado : ProdutoUsado
    {
        public double CustoDeTaxa { get; set; }
    // Contrutor padrão 
        public ProdutoImportado()
        {

        }

        public ProdutoImportado(double custoDeTaxa)
        {
            CustoDeTaxa = custoDeTaxa;
        }
        public string TagPreco()
        {
            return CustoDeTaxa.ToString();
        }
        public double PrecoFinal()
        {
            double precoTotal = CustoDeTaxa * PrecoFinal();
            return precoTotal;  
        }
    }
    
}
