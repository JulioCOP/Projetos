using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosContratuais.Entities
{
    internal class HourContract
    {
        // Propriedade que representa a data do contrato
        public DateTime Data { get; set; }
        
        // Valor por hora do contrato do trabalhador
        public double ValuePerHour { get; set; }

        // Horas do de duração do contrato
        public int Hours { get; set; }

        // Construtor padrão
        public HourContract()
        {

        }
        // Construtor com argumentos
        public HourContract(DateTime data, double valuePerHour, int hours)
        {
            Data = data;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }
        // Para essa classe - criar o método

        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }

    }
}
