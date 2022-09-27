

namespace SistemaDePedidos.Entities.Enums
{
    // Tipo é enum 
    // Todos o valores de enum serão valores inteiros
    enum OrderEStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3 
    }
}
