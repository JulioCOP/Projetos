using ProjetoExemplo1.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
namespace ProjetoExemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Acount> list = new List<Acount>();
            list.Add(new SavingsAccount(1001,"Alex", 500.0, 0.01));
            list.Add(new BusinessAccount (1002,"Maria", 500.0, 400.0));
            list.Add(new SavingsAccount (1003, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Anna",500.0,500.0));
            // Devido a superclasse genérica(abstract Acount), é possível adicionar valores as conts, de acordo com as informações passadas pelo usuário
            double sum = 0.0;
            foreach(Acount acc in list)
            {
                sum+=acc.Balance;
            }
            Console.WriteLine("Total balance: "+ sum.ToString("F2", CultureInfo.InvariantCulture));
            // métodos polimorficos
            foreach(Acount acc in list)
            {
                acc.Withdraw(25.50);

            }
            foreach(Acount acc in list)
            {
                Console.WriteLine("Atuaização do conta bancária" + acc.Number + " : " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));

            }
        }
        
    }
}