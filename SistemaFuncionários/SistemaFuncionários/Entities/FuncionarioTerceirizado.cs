using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFuncionarios.Entities
{
    internal class FuncionarioTerceirizado :Empregados
    {
        public double CargaAdicional { get; set; }

        public FuncionarioTerceirizado (string nome, int horas, double valorPorHora, double cargaAdicional) : base(nome, horas, valorPorHora)
        {
            CargaAdicional = cargaAdicional;
        }
        public double Pagamento()
        {
            return CargaAdicional;
        }
    }
}
