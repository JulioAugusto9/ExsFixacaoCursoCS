using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExsFixacaoCursoCS.Pt9EnumEComposicao
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public double Total()
        {
            double sum = 0;
            foreach (var item in Items) sum += item.SubTotal();
            return sum;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append($"Order moment: {Moment}\n" +
                $"Order status: {Status}\n" +
                $"Client: {Client}\n");
            if (Items.Count > 0) str.Append("Order items:\n");
            foreach (var item in Items)
            {
                str.Append(item + "\n");
            }
            str.Append($"Total price: ${Total().ToString("F2", CultureInfo.InvariantCulture)}\n");
            return str.ToString();
        }
    }
}
