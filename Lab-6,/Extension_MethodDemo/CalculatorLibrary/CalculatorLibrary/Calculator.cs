using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary
{
    public class Calculator
    {
        public int res;
        
        public int Num1 { get; set; }
        public int Num2 { get; set; } 

        public int Add()
        {
            res = Num1 + Num2;
            return res;
        }

        public int Sub()
        {
            res = Num1 - Num2;
            return res;
        }
    }
}
