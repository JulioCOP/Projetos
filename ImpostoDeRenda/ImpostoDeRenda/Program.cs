using ImpostoDeRenda.Entities;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace ImpostoDeRenda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Taxa> list = new List<Taxa>();
            Console.Write("Informe o número de pessoas: ");
            int numPessoas= int.Parse(Console.ReadLine());
            for (int i = 0; i < numPessoas; i++)
            {
                Console.Write("Pessoa FÍSICA [F] ou JURÍDICA [J] ?");
                char contribuinte = char.Parse(Console.ReadLine());
                if (contribuinte == 'F' || contribuinte == 'f')
                {
                    Console.Write("NOME DA PESSOA FÍSICA: ");
                    string nome = Console.ReadLine();
                    Console.Write($"Salário ANUAL DE {nome} EM R$: ");
                    double anualmente = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write($"{nome}, quanto foi seu gasto em saúde neste ano ? ");
                    double gastoSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new PessoaFisica(nome, anualmente, gastoSaude));
                }
                else if (contribuinte == 'J' || contribuinte == 'j')
                {
                    Console.Write("NOME DA PESSOA JURÍDICA: ");
                    string nome = Console.ReadLine();
                    Console.Write($"Salário ANUAL DE {nome} EM R$: ");
                    double anualmente = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write($"{nome}, quantos funcionários há na empresa ? ");
                    int numerodefuncionarios = int.Parse(Console.ReadLine());
                    list.Add(new PessoaJuridica(nome, anualmente, numerodefuncionarios));
                }
                else
                {
                    Console.WriteLine("ERROR !!! ");
                }
            }
            // VARIAVEL PARA SOMAR O TOTAL DE IMPOSTOS ARRECADADOS
            double somaImposto = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXA DE IMPOSTOS PELOS USÁRIOS INFORMADOS");
            foreach(Taxa taxa in list)
            {
                double impost = taxa.Imposto();
                Console.WriteLine(taxa.Nome + ": R$ " + impost.ToString("F2", CultureInfo.InvariantCulture));
                somaImposto += impost;

            }
            Console.WriteLine();
            Console.WriteLine("TOTAL DE IMPOSTOS ARRECADADOS: R$ " + somaImposto.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}