using System;
using System.Text;
using System.IO;
using CriarArquivoCsv.Repositories;

namespace CriarArquivoCsv
{
    class Program
    {
        static void Main(string[] args)
        {
            // Buscar a pessoa no repositório 
            // Gerar o arquivo 
            // Salvar o arquivo

            Console.WriteLine("Bucar pessoas");
            var people = PersonRepository.GetPeople(); // Lista aonde será buscado os arquivos
            StringBuilder sb  = new StringBuilder();
            Console.WriteLine("Gerar o arquivo");
            sb.AppendLine("Nome;CPF");

            //Rodar a lista e adicionar as pessoas dentro do StringBuilder
            people.ForEach(x => sb.AppendLine(($"{x.Name}; {x.Document}"))); // Adição dos dados no Csv
            var filePath = @"F:\Curso POO C#/pessoa.csv";

            Console.WriteLine("Salvar arquivo");
            File.WriteAllText(filePath, sb.ToString()); 
            Console.ReadKey();
        }
    }
}