using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtiquetaProduto.Entities
{
    internal class ProdutoUsado
    {
        public DateTime DataFabricacao { get; set; }

        public ProdutoUsado()
        {

        }
        public ProdutoUsado(DateTime dataFabricacao)
        {
            DataFabricacao = dataFabricacao;
        }
        public string TagPreco()
        {
            return DataFabricacao.ToString();
        }

    }
}
