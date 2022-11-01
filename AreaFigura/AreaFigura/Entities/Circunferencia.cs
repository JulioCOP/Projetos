using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaFigura.Entities
{
     class Circunferencia : Figura
    {
        public double Radiano { get; set; }
        public Circunferencia()
        {

        }
        public Circunferencia(double radiano)
        {
            Radiano = radiano;
        }
        public override double Area()
        {
            return Math.PI * Radiano * Radiano;
        }
    }
}
