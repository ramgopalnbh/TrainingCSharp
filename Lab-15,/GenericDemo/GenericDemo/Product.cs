﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GenericDemo
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Price{ get; set; }

        public override string ToString()
        {
            return Id + " " + Title + " " + Price;
        }
    }
}
