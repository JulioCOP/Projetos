using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ImpostoDeRenda.Entities
{
    class PessoaJuridica : Taxa
    {
        public int NumeroDeFuncionarios { get; set; }

        public PessoaJuridica()
        {

        }
        public PessoaJuridica (int numerodefuncionarios)
        {
            NumeroDeFuncionarios = numerodefuncionarios;
        }
        public override double Imposto()
        {
           if (NumeroDeFuncionarios > 10)
            {
                 double impostoAPagar = ((Anualmente * 14) / 100);
                return impostoAPagar;
            }
            else
            {
                double impostoAPagar = ((Anualmente *16) /100);
                return impostoAPagar;

            }
        }
    }
}
