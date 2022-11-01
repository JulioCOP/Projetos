using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaFigura.Entities
{
    class Retangulo: Figura
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo()
        {

        }
        public Retangulo(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }

        public override double Area()
        {
            return  Largura * Altura;
        }
    }

}
