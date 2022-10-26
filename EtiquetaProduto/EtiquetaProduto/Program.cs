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
                else
                {
                    Console.WriteLine("INFORME A OPÇÃO CORRETA");
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

// DIA 24/10 - Logica inicial e estruturas inicial do programas 
        // *** Conferir a herança das classes dos produtos importados e usados 
// Dia 25/10 - Verificado todas as classes e consertado erro de herança das classes produto importado e produto usado
           // -Adicionado comando virtual a função tagPreco na classe produto, para que assim a função possa ser herdada pelas outras classes
        // *** Conferir lógica e continuar fazendo os códigos do programa principal que irá fazer a comunicação com as classes
// Dia 26/10 - Adicionado comandos ao programa principal, para que o usúario possa informar os dados do produto a ser adquirido e o prpgrama lhe dê informações de acordo com sua classe e 
                // informações passadas pelo usuário. Se é importado, usado ou novo.
        // *** Verificar operadores - Função não retorna outro valor, quando informado uma opção além daquelas solicitadas pelo programa - Se o produto é novo, usado ou importado