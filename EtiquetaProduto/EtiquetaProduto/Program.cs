using System;
using System.Globalization;

namespace EtiquetaProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a quantidade de produtos: ");
            int qtdProdutos = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtdProdutos; i++)
            {
                Console.WriteLine($" DADOS DO PRODUTO #{i}");
                Console.Write("Novo, usado ou importado ? [C] / [U] / [I] ");
                char tipoProduto = char.Parse(Console.ReadLine());
            }
        }
    }
}

// DIA 24/10 - Logica inicial e estruturas inicial do programas 
        // *** Conferir a herança das classes dos produtos importados e usados 