using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Cart
    {
        public int id { get; set; }
        public Dictionary<Product, int > products { get; set; }

        public Cart(int id)
        {
            this.id = id;
        }

        public override string ToString()
        {
            return "\nCart: " +
                "\nId: " + id + " - " +
                "Products: " + products;
        }

    }
}