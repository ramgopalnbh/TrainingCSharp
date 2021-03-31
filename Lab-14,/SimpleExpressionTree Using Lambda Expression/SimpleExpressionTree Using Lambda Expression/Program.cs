using System;

namespace SimpleExpressionTree_Using_Lambda_Expression
{
    class Program
    {
        static void Main(string[] args)
        {

            //Func<int, int> square = (x) => { return x * x; }; //Lambda Statement

            //Func<int, int> square = (x) => x * x;               //Lambda Expression
            //Console.WriteLine(square(6));

            System.Linq.Expressions.Expression<Func<int, int>> e = x => x * x; //Expression Tree
            var a = e.Compile();
            Console.WriteLine(e); //It will print expression tree.
            Console.WriteLine(a(7));

        }
    }
}
