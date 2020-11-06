using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsOrdering.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }

        public Product Prod { get; set; }

        public OrderItem()
        { 
        }

        public OrderItem(int quantity, string name, double price)
        {
            Prod = new Product(name, price);
            Quantity = quantity;
        }

        public double SubTotal()
        {
            return Prod.Price * Quantity;
        }

        public override string ToString()
        {
            StringBuilder ItemSb = new StringBuilder();
            ItemSb.Append(Prod.Name + ", " + Prod.Price + ", " + Quantity);
            return ItemSb.ToString();
        }
    }
}
