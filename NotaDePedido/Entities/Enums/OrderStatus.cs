using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaPedidos.Entities.Enums
{
    enum OrderStatus : int
    {
       PagametnoPendente=0,
       Processando=1,
       Enviado =2,
       Entregue =3
    }
}
