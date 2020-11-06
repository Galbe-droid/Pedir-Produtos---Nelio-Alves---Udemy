using ProductsOrdering.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsOrdering.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        List<OrderItem> orderItem { get; set; } = new List<OrderItem>();

        public Order()
        { 
        }

        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;
        }

        public void AddItem(OrderItem item)
        {
            orderItem.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            orderItem.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach (OrderItem item in orderItem)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order Itens.");
            foreach (OrderItem item in orderItem)
            {
                sb.AppendLine(item.ToString());
            }
            sb.Append("Total: ");
            sb.Append(Total());
            return sb.ToString();
        }
    }
}
