using ImpostoDeRenda.Entities;
using System;
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
                    double salarioAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write($"{nome}, quanto foi seu gasto em saúde neste ano ? ");
                    double gastoSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                else if (contribuinte == 'F' || contribuinte == 'f')
                {
                    Console.Write("NOME DA PESSOA JURÍDICA: ");
                    string nome = Console.ReadLine();
                    Console.Write($"Salário ANUAL DE {nome} EM R$: ");
                    double salarioAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write($"{nome}, quantos funcionários há na empresa ? ");
                    int funcionarios = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("ERROR !!! ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXA DE IMPOSTOS PELOS USÁRIOS INFORMADOS");
            foreach(Taxa taxa in list)
            {
                Console.WriteLine(taxa.Imposto().ToString());
            }
        }
    }
}