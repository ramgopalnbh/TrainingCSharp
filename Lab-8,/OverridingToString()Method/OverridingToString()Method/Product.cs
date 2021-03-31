using System;
using System.Collections.Generic;
using System.Text;

namespace OverridingToString__Method
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return "Id: "+Id+", Title: "+Title+", Price: "+Price;
        }
    }
}
