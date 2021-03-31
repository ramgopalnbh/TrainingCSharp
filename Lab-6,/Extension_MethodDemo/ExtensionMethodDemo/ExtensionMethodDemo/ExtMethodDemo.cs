using CalculatorLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethodDemo
{
    public static class ExtMethodDemo
    {
        public static int Mul(this Calculator c)
        {
            int res = c.Num1 * c.Num2;
            return res;
        }

        public static int countVowel(this string str)
        {
            int count =0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'A' || str[i] == 'E' || str[i]=='I' ||str[i]== 'O' ||str[i]== 'U')
                {
                 count++;
                }
            }
            return count;
        }
    }
}
