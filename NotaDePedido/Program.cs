using NotaPedidos.Entities;
using NotaPedidos.Entities.Enums;
using System;
using System.Globalization;

namespace NotaPedidos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe os dados do cliente");
            Console.Write("Nome: ");
            string nome= Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Data de nacimento: ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Console.Write("STATUS DO PEDIDO ([0] - Pagamento Pendente [1]-Processando [2]-Enviado [3]-Entregue): ");
            OrderStatus statusPedido= Enum.Parse<OrderStatus>(Console.ReadLine());
            Cliente cliente = new Cliente(nome, email, data);
            Ordem ordem = new(DateTime.Now, statusPedido, cliente);

            Console.WriteLine($"Quantos itens foram comprados por {nome}");
            int numeroPedidos = int.Parse(Console.ReadLine());

            for (int i=1; i <= numeroPedidos; i++)
            {
                Console.WriteLine($"Informe os dados do pedido Nº {i}");
                Console.Write("Nome do produto: ");
                string nomeProduto = Console.ReadLine();
                Console.Write("Preço do produto R$: ");
                double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                // Produto e preço é referente aos atributos da classe Produto 
                // Após o usuário informar os dados, devem ser adicionados nos atributos da clase através do istanciamento

                Produto produto = new Produto(nomeProduto, precoProduto);

                Console.Write($"Quantos(as) {nomeProduto} foram comprados ? ");
                int quantidade = int.Parse(Console.ReadLine());
                OrdemItem ordemItem = new OrdemItem(quantidade, precoProduto);
                ordem.AddItem(ordemItem);
            }
            Console.WriteLine();
            Console.WriteLine("DADOS DO PEDIDO");
            Console.WriteLine(ordem);
        }
    }
}