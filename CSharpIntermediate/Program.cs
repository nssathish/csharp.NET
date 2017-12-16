using System;

namespace CSharpIntermediate
{
    class Program
    {
        public static void Main(string[] args)
        {
            var customer = new Customer(1234, "Sathish");
            var order = new Order();
            customer.orders.Add(order);
            Console.WriteLine("Hello World!");
        }
    }
}
