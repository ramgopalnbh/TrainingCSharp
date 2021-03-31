using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateCalculatorApp
{
    public class Calculator
    {
        public delegate void PerformCalculation(int num1, int num2);

        public void Addition(int num1, int num2)
        {
            int res = num1 + num2;
            Console.WriteLine($"Addition of num1 and num2 is: {res}");
        }

        public void Subtraction(int num1, int num2)
        {
            int res = num1 - num2;
            Console.WriteLine($"Subtraction of num1 and num2 is: {res}");
        }

        public void Multiplication(int num1, int num2)
        {
            int res = num1 + num2;
            Console.WriteLine($"Multiplication of num1 and num2 is: {res}");
        }

        public void Division(int num1, int num2)
        {
            int res = num1 / num2;
            Console.WriteLine($"Division of num1 and num2 is: {res}");
        }

        public void DisplayCalculation(PerformCalculation pc);
        {

        }
    }
}
