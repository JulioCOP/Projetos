using NotaPedidos.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaPedidos.Entities
{
    internal class Ordem
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        // Propriedade com composição de objeto - Relação 1 para 1
        public Cliente Cliente { get; set; }

        // Lista para adicionar ou remover os itens informados pelo usuário
        List<OrdemItem> OrdemDosItens { get; set; } = new List<OrdemItem>();

        public Ordem()
        {
        }

        public Ordem(DateTime moment, OrderStatus status, Cliente cliente)
        {
            Moment = moment;
            Status = status;
            Cliente = cliente;
        }
        // Propriedade para adicionar os varios itens a serem informados pelo usuário

        public void AddItem(OrdemItem itens)
        {
            OrdemDosItens.Add(itens);
        }
        public void RemoveItem(OrdemItem itens)
        {
            OrdemDosItens.Remove(itens);
        }
        public double Total()
        {
            // Ao iniciar não tem nenhum produto, preço ou quantidade informado
            double soma = 0;

            //Programa deve percorrer os itens da lista de OrdemItem dos pedidos informados pelo usuário
            foreach (OrdemItem itens in OrdemDosItens)
            {
                // Para cada itens da lista OrdemIten, dentro da variavel OrdemDosItens realizar a somatória dos itens
                soma += itens.Subtotal();
            }
            return soma;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Momento do pedido: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy  HH:mm:ss"));
            sb.Append("Status do pedido: ");
            sb.AppendLine(Status.ToString());
            sb.AppendLine("Dados do Cliente(Nome / Data de nascimento / Email: " + Cliente);
            sb.AppendLine("Ordem dos pedidos: ");
            foreach (OrdemItem itens in OrdemDosItens)
            {
                sb.AppendLine(itens.ToString());
            }
            sb.AppendLine($"Preço total da compra de {Cliente} R$: {Total:2}");
            return sb.ToString();
        }
    }
}
