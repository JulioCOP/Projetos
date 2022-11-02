using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpostoDeRenda.Entities
{
    abstract class Taxa
    {
        public string Nome { get; set; }
        public double Anualmente { get; set; }

        public Taxa()
        {

        }
        public Taxa(string nome, double anualmente)
        {
            Nome = nome;
            Anualmente = anualmente;
        }
        public abstract double Imposto();
    }
}
