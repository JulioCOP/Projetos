using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFuncionarios.Entities
{
    internal class Empregados
    {
        public string Nome { get; set; }
        public int Horas { get; set; }
        public double ValorPorHora { get; set; }

        public Empregados()
        // Constutor básico, caso seja necessário acrescentar algo
        {

        }
        public Empregados(string nome, int horas, double valorPorHora)
        {
            Nome = nome;
            Horas = horas;
            ValorPorHora = valorPorHora;
        }   
        public double Pagamento()
        {
            return ValorPorHora * Horas;
        }
    }
}
