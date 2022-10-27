using EtiquetaProduto.Entities;
using System;
using System.Globalization;

namespace EtiquetaProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Listar a classe produto, para que os dados informados pelo usuário possam ser adicionados 
            List<Produto> list = new List<Produto>();
            Console.Write("Informe a quantidade de produtos: ");
            int qtdProdutos = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtdProdutos; i++)
            {
                Console.WriteLine($" DADOS DO PRODUTO #{i+1}");
                Console.Write("Novo, usado ou importado ? [N] / [U] / [I] ");
                char tipoProduto = char.Parse(Console.ReadLine());
                while (tipoProduto != 'N' || tipoProduto!='n' || tipoProduto != 'U' || tipoProduto != 'u' || tipoProduto != 'I' || tipoProduto != 'i')
                {
                    Console.WriteLine("INFORME A OPÇÃO CORRETA");
                    Console.WriteLine($" DADOS DO PRODUTO #{i + 1}");
                    Console.Write("Novo, usado ou importado ? [N] / [U] / [I] ");
                    tipoProduto = char.Parse(Console.ReadLine());
                    if (tipoProduto == 'N' || tipoProduto == 'n' || tipoProduto == 'U' || tipoProduto == 'u' || tipoProduto == 'I' || tipoProduto == 'i') 
                    { 
                        break;
                    }
                }
                Console.Write("NOME DO PRODUTO: ");
                string nome = Console.ReadLine();
                Console.Write("PREÇO DO PRODUTO: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (tipoProduto == 'N'|| tipoProduto == 'n')
                {
                   list.Add(new Produto(nome, preco));
                }
                else if (tipoProduto=='U' || tipoProduto== 'u')
                {
                    Console.WriteLine("PRODUTO USADO.");
                    Console.Write($" Por gentileza, informe a data de fabricação do(a) {nome}");
                    DateTime dataFabricacao = DateTime.Parse(Console.ReadLine());
                    list.Add(new ProdutoUsado(nome, preco, dataFabricacao));
                }
                else if (tipoProduto == 'I' || tipoProduto == 'i')
                {
                    Console.WriteLine("Produto importado pelo usuário");
                    Console.Write("Por favor, informe a taxa em %, cobrada pela alfândega: ");
                    double custoDeTaxa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ProdutoImportado(nome, preco, custoDeTaxa));
                }
            }
            Console.WriteLine();
            Console.WriteLine("ETIQUETA DE PREÇO");
            foreach(Produto produto in list)
            {
                Console.WriteLine(produto.tagPreco());
            }

        }
    }
}
