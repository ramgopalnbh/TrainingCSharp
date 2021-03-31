using System;
using System.Collections.Generic;
using System.Text;

namespace CountVowelsUsing_ExtensionMethod
{
    public static class ExtensionDemo
    {
        public static int ConutVowels(this string str)
        {
            int count = 0;
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
