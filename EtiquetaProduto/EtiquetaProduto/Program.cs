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
// Dia 25/10 - Verificado todas as classes e consertado erro de herança das classes produto importado e produto usado
           // -Adicionado comando virtual a função tagPreco na classe produto, para que assim a função possa ser herdada pelas outras classes
        // *** Conferir lógica e continuar fazendo os códigos do programa principal que irá fazer a comunicação com as classes