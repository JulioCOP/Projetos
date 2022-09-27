using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Inserido enums
using SistemaDePedidos.Entities.Enums;

namespace SistemaDePedidos.Entities
{
    internal class Order
    {
        // Propriedade id -  codigo do produto
        public int Id { get; set; }

        // Instante do pedido
        public DateTime Moment { get; set; }

        // Status do pedido

        public OrderEStatus Status { get; set; }

        public override string ToString()
        {
            return Id +  " , " + Moment + " , " + Status;

            
        }
    }
}
