using CalculatorLibrary;
using System;

namespace ExtensionMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Calculator c = new Calculator
            {
                Num1 = 20,
                Num2 = 30
            };
            int a =c.Add();
            int b =c.Sub();
            int d = c.Mul();
            string st = "BHARAT";
         
            int e = st.countVowel();
            Console.WriteLine("Addition: "+a);
            Console.WriteLine("Subtraction: " + b);
            Console.WriteLine("Multiplication: " + d);
            Console.WriteLine(e);

        }
    }
}
