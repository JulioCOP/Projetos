using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaPedidos.Entities
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataDeNascimento { get; set; }

        // Construtor padrão
        public Cliente()
        {
        }

        public Cliente(string nome, string email, DateTime dataDeNascimento)
        {
            Nome = nome;
            Email = email;
            DataDeNascimento = dataDeNascimento;
        }
        public override string ToString()
        {
            return Nome + Email + DataDeNascimento;
        }
    }

}
