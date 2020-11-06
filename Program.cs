using ProductsOrdering.Entities;
using ProductsOrdering.Entities.Enum;
using System;

namespace ProductsOrdering
{
    class Program
    {
        static void Main(string[] args)
        {
            Client c = new Client("Gabriel", "email@email.com", new DateTime(1994,10,21));
            Order o = new Order();
            OrderItem i;
            
            int quantity;
            double price;
            string productName;
            int productQuantity;

            Console.WriteLine(c);
            Console.WriteLine("How many products were brought ?");
            Console.Write("Qty: ");
            quantity = int.Parse(Console.ReadLine());
            o.Moment = DateTime.Now;

            for (int control = 0; control < quantity; control++)
            {
                Console.WriteLine($"Product #{control + 1}");
                Console.WriteLine("Product Information.");
                Console.Write("Name: ");
                productName = Console.ReadLine();
                Console.Write("Price: ");
                price = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                productQuantity = int.Parse(Console.ReadLine());

                i = new OrderItem(productQuantity, productName, price);

                o.AddItem(i);
            }

            Console.WriteLine("Order Summary");
            Console.WriteLine("Order Moment: " + o.Moment);
            Console.WriteLine("Order Status: " + OrderStatus.Processing.ToString());
            Console.WriteLine(c.ToString());
            Console.WriteLine(o.ToString());
            Console.ReadLine();
        }
    }
}
