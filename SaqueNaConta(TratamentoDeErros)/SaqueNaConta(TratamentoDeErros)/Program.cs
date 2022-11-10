using System;
using System.Diagnostics.Tracing;
using System.Globalization;

namespace SaqueNaConta_TratamentoDeErros_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DADOS DA CONTA BANCÁRIA");
            Console.Write("NÚMERO: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("TITULAR DA CONTA: ");
            string titular= Console.ReadLine();
            Console.Write("SALDO INICIAL DA CONTA: ");
            double contaInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("SAQUE LIMITE PERMITIDO: ");
            double saqueLimite = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

         //DIA 09/11/2022 -
         //             Adicionado comandos iniciais ao programa principal
         //             Alterado comando na entidade Poupança -  Implementação de superclasse
                                             //                 - Herança das classes da entidade e das execeções  
        }
    }
}