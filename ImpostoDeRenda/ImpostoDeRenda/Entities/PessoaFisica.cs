using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoDeRenda.Entities
{
    class PessoaFisica : Taxa
    {
        public double GastoSaude { get; set; }
        
        public PessoaFisica()
        {

        }
        public PessoaFisica (double gastosaude)
        {
            GastoSaude = gastosaude;
        }
        public override double Imposto()
        {
            return (((Anualmente * 25)/100) - ((GastoSaude*50)/100));
        }
    }
}
