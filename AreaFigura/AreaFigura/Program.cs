using AreaFigura.Entities;
using AreaFigura.Entities.Enums;
using System;
using System.Globalization;

namespace AreaFigura
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> list = new List<Figura>();
            Console.Write("Informe a quantidade de figuras");
            int qtdFiguras = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtdFiguras; i++)
            {
                Console.WriteLine($"DADOS DA FIGURA Nª {i+1}");
                Console.Write("RETÂNGULO [ R ] / CIRCUNFERÊNCIA [ C ]");
                char formato = char.Parse(Console.ReadLine());
                Console.Write($"COR DA FIGURA Nª {i + 1}: PRETO / VERMELHO / AZUL");

                Cores cores = Enum.Parse<Cores>(Console.ReadLine());
                if (formato == 'R' || formato == 'r')
                {
                    Console.WriteLine("A figura selecionada foi um retângulo, informe a altura e a largura desta figura: ");
                    Console.Write("ALTURA: ");
                    double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("LARGURA: ");
                    double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Retangulo(altura, largura));
                }
                if (formato == 'C' || formato == 'c')
                {
                    Console.WriteLine("A figura selecionada foi uma circunferência, informe se raio: ");
                    Console.Write("RAIO: ");
                    double radiano = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circunferencia(radiano));
                }
                Console.WriteLine();
                Console.WriteLine("ÁREAS DAS FIGURAS INFORMADAS PELO USUÁRIO");
                foreach (Figura figura in list)
                {
                    Console.WriteLine(figura.Area().ToString());
                }

            }
        }
    }
}