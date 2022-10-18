using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFuncionarios.Entities
{
    internal class FuncionarioTerceirizado : Empregados
    {
        public double CargaAdicional { get; set; }

        public FuncionarioTerceirizado()
        {

        }
        public FuncionarioTerceirizado (string nome, int horas, double valorPorHora, double cargaAdicional) : base(nome, horas, valorPorHora)
        {
            CargaAdicional = cargaAdicional;
        }
        // Sobreposição do método
        public override double Pagamento()
        // Overrride - para a função retornar a função da classe de empregado, referente ao pagamento, que será subescrito, em caso de funcionario terceirizado
        {
            return base.Pagamento() + 1.1*CargaAdicional;
        }
    }
}
