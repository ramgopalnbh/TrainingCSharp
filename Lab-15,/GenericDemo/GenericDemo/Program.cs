using System;

namespace GenericDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            TestGeneric<int> obj = new TestGeneric<int>();

            obj.Add(23);
            obj.Add(34);
            obj.Add(47);
            obj.Add(78);
            obj.Add(100);

            TestGeneric<Product> objP = new TestGeneric<Product>();
            objP.Add(new Product { 
                Id=101,
                Title="Pen",
                Price=100
            });

            objP.Add(new Product
            {
                Id = 102,
                Title = "Pencil",
                Price = 10
            });

            objP.Add(new Product
            {
                Id = 103,
                Title = "Notebook",
                Price = 100
            });

            for (int i = 0; i < 5; i++)
            {
                Console.Write(obj[i]+" ");
                //Console.WriteLine(objP[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                //Console.Write(obj[i] + " ");
                Console.WriteLine(objP[i]);
            }

            //int a = 20;
            //int b = 30;
            Product a = new Product() { Price = 100};
            Product b = new Product() { Price = 111};


            Console.WriteLine($"Before Swaping a= {a.Price} and b={b.Price}");

            Swap<Product>(ref a,ref b);
            Console.WriteLine($"After Swaping a= {a.Price} and b={b.Price}");

            static void Swap<T>(ref T a, ref T b)
            {
                T Temp;
                Temp = a;
                a = b;
                b = Temp;
            }
        }
    }
}
