using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtiquetaProduto.Entities
{
    internal class ProdutoUsado: Produto
    {
        public DateTime DataFabricacao { get; set; }

        public ProdutoUsado()
        {

        }
        public ProdutoUsado(string nome, double preco, DateTime dataFabricacao) : base(nome,preco)
        {
            DataFabricacao = dataFabricacao;
        }
        public override string tagPreco()
        {
            return Nome + "( USADO ) " + "R$ " + Preco.ToString("F2",CultureInfo.InvariantCulture) + " -> " + " DATA DE FABRICAÇÃO: " + DataFabricacao.ToString();
        }

    }
}
