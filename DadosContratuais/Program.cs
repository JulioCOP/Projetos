using DadosContratuais.Entities;
using DadosContratuais.Entities.Enums;
using System;
using System.Globalization;

namespace DadosContratuais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do departamento: ");
            string deptNome = Console.ReadLine();
            Console.WriteLine("Informe os dados do trabalhador ");
            Console.Write("NOME: ");
            string nome = Console.ReadLine();
            Console.Write("Qual o nivel do trabalhador (JUNIOR/MIDLEVEL/SENIOR) ? ");
            // Cnverter string para Enumeração
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Informe o salario base R$: ");
            double baseSalario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Instanciar os objetos de acordo com diagrama UML

            // Instanciar departamento  de acordo com o nome informado pelo usuário
            Department dept = new Department(deptNome);

            // Instanciar os dados do trabalhador com o departamento, uma vez que estão associados, de acordo com o diagrama 
            Worker trabalhador = new Worker(nome, level, baseSalario, dept);

            // Qtd de contratos a ser cadastrados
            Console.Write("Quantos contratos estarão associados a esse trabalhador ? ");
            int n = int.Parse(Console.ReadLine());

            // estrutura de repetição for -> Dados serão armazenados de acordo com a quantidade de contratos que este trabalhador terá
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Informe o contrato Nº {i}");
                Console.Write("DATA: ");
                // chamar a classe data
                DateTime data = DateTime.Parse(Console.ReadLine());
                // chamar a classe de valor/hora do contrato
                Console.Write("Valor/Hora R$: ");
                double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Horas: ");
                int horas = int.Parse(Console.ReadLine());

                // Necessário instanciar um contrato, para adicionar os dados informados

                HourContract contrato = new HourContract(data, valorPorHora, horas);

                // Adicionar o contrato instanciado no comando anterior
                trabalhador.AddContract(contrato);
                // Dados do contrato serão adicionados pelo deacordo o N vezes informado pelo usuário
            }

            Console.Write("Informe o mês e ano de acordo com o formato MM/YYYY: ");
            string mesEAno = Console.ReadLine();

            // Função substring para recortar os dados informados de mes e ano e retornar de acordo com a posição armazenada na memoria

            int mes = int.Parse(mesEAno.Substring(0, 2));
            int ano = int.Parse(mesEAno.Substring(3));
            Console.WriteLine();

            Console.WriteLine($"Nome: {trabalhador.Name}");
            Console.WriteLine($"Departamento: {trabalhador.Department.Name}");
            Console.WriteLine($"Rendimento anual {mesEAno} : {trabalhador.Income(ano, mes)}");
        }
    }
}