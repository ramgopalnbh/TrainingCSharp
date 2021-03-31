using System;

namespace OverridingToString__Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product
            {
                Id = 101,
                Title = "Car",
                Price = 500000
            };
            Product p1 = new Product
            {
                Id = 102s,
                Title = "Bike",
                Price = 150000
            };

            Console.WriteLine(p);
            Console.WriteLine(p1);
        }
    }
}
