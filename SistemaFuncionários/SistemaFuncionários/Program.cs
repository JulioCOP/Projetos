using SistemaFuncionarios.Entities;
using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

namespace SistemaFuncionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empregados> list = new List<Empregados>(); 
            // Guardar os dados dos empregados em uma lista

            Console.Write("Qual o número de funcionários ? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Funcionário #{i+1}");
                Console.Write("É um funcionário terceirizado ? [S] / [N] ");
                char func = char.Parse(Console.ReadLine());
                Console.Write("NOME: ");
                string nome = Console.ReadLine();
                Console.Write($"Informe as horas trabalhadas do funcionário(a) {nome}: ");
                int horas = int.Parse(Console.ReadLine());
                Console.Write("Informe o valor/hora deste funcionário R$: ");
                double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (func=='s'|| func == 'S')
                {
                    Console.Write("Informe a despesa adicional a ser recebida por este funcionário: ");
                    double cargaAdicional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    // Adicionar na lista a classe de funcionário terceirizado
                    list.Add(new FuncionarioTerceirizado(nome, horas, valorPorHora, cargaAdicional));
                }
                else
                {
                    list.Add(new Empregados(nome,horas,valorPorHora));
                }
            }
            // Percorrer a lista, chamando a função de pagamento de Pagamento para cada elemento da lista
            Console.WriteLine();

            Console.WriteLine("PAGAMENTOS");
            // Para cada funcionário da lista, deve ser imprimido o nome e o valor a ser recebido 
            foreach(Empregados emp in list)
            {
                // Console.WriteLine(emp.ToString()); -> Apenas com este comando, será retornado o local onde a função pagamento está adicionado
                Console.WriteLine(emp.Nome + "---" + "R$" + emp.Pagamento().ToString());
            }
        }
    }
}
