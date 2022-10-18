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
        public virtual double Pagamento()
        // Virtual -  metodo deve ser subescrito, pois o o funcionário receberá o pagamento que é o resultado de suas horas trabalhadas * o valor que essa hora custa 
        // Em caso de funcionário terceirizados, o resultado da multiplicação anterior é acrescido 110% da despesa adicional informada.
        {
            return ValorPorHora * Horas;
        }
    }
}
