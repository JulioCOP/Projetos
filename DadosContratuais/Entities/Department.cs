using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosContratuais.Entities
{
    internal class Department
    {
        public string Name { get; set; }

        // Construtor padrão da classe

        public Department()
        {

        }
        // Construtor que recebe o nome como argumento

        public Department(string name)
        {
            Name = name;
        }
    }
}
