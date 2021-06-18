using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExsFixacaoCursoCS.Pt9EnumEComposicao
{
    class Pt9Ex1
    {
        public static void Run()
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birth = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birth);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status;
            Enum.TryParse(Console.ReadLine(), out status);

            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            for (int i=0; i<n; i++)
            {
                Console.WriteLine($"Enter #{i+1} item data:");
                Console.Write("Product name: ");
                name = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int qty = int.Parse(Console.ReadLine());

                Product product = new Product(name, price);
                OrderItem item = new OrderItem(product, qty);
                order.AddItem(item);
            }

            Console.WriteLine("ORDER SUMMARY:\n" 
                + order.ToString());
        }
    }
}
