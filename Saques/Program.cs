using ProjetoExemplo1.Entities;
using System;
namespace ProjetoExemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Acount acc1 = new Acount(1001, "Alex", 500.0);
            Acount acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

            // Declaração das variaveis e sua instanciação são caracteristicas de polimorfismo

            // São objetos diferentes que são atribuidos a variaveis do tipo count por causa do upcasting
            
            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);
            // Cada operação de saque de acordo com as variadas criadas acima , possui comportamentos diferentes devido a sua instanciação de metodos diferentes (Acount e SavingsAcount)

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
        
    }
}