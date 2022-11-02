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
        public PessoaFisica(string nome, double anualmente, double gastosaude) : base(nome, anualmente) 
        {
            Nome = nome;
            Anualmente = anualmente;
            GastoSaude = gastosaude;

        }
        public override double Imposto()
        {
            if (Anualmente < 20000)
            {
                double imposto = (((Anualmente * 15) / 100) - ((GastoSaude * 50) / 100));
                return imposto;
            }
            else
            {
                double imposto = (((Anualmente * 25) / 100) - ((GastoSaude * 50) / 100));
                return imposto;
            }
        }
    }
}
