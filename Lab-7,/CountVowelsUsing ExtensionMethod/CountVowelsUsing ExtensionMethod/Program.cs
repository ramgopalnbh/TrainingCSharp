using System;

namespace CountVowelsUsing_ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "BHARAT";
            int i=str.ConutVowels();
            Console.WriteLine($"Vowels are {i} in {str}");
        }
    }
}
