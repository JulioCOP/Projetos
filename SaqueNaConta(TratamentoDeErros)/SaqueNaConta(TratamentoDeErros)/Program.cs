using SaqueNaConta_TratamentoDeErros_.Entities;
using SaqueNaConta_TratamentoDeErros_.Entities.Exceptions;
using System;
using System.Diagnostics.Tracing;
using System.Globalization;
namespace SaqueNaConta_TratamentoDeErros_
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("DADOS DA CONTA BANCÁRIA");
            Console.Write("NÚMERO: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("TITULAR DA CONTA: ");
            string titular = Console.ReadLine();
            Console.Write("SALDO INICIAL DA CONTA: ");
            double contaInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("SAQUE LIMITE PERMITIDO: ");
            double saqueLimite = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Poupanca popanca = new Poupanca(numero, titular, contaInicial, saqueLimite);
            
            Console.WriteLine();
            Console.Write("Informe a quantidade do saque: ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try
            {
                popanca.Saque(quantidade);
                Console.WriteLine("Novo saldo: " + popanca.Conta.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch(DomainException e)
            {
                Console.WriteLine("IMPOSSÍVEL REALIZAR SAQUE: " + e.Message);
            }
        }
    }
}
 

