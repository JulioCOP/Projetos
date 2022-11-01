
using AreaFigura.Entities.Enums;

namespace AreaFigura.Entities
{
     abstract class Figura
    {
        public Cores Cores { get; set; }
        // Construtor padrão
        public Figura()
        {

        }
        public Figura(Cores cores)
        {
            Cores = cores;
        }
        // A Figura, é um tipo genérico -> classe abstrata
        public abstract double Area(); 

    }
}
