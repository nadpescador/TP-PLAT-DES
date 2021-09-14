using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ConsoleApp1
{
    class Product : IComparable<Product>
    {
        public int id { get; set; }
        public String name { get; set; }
        public double price { get; set; }
        public int amount { get; set; }
        public Category category { get; set; }

        //public Product(int id, String name, double price, int amount, Category category)
        //{
            //this.id = id; 
            //this.name = name;
            //this.price = price;
            //this.amount =amount;
            //this.category = category;
        //}

        public Product() { }


        public int CompareTo( Product other)
        {
            return name.CompareTo(other.name);
        }

        public override string ToString()
        {
            return "\nProduct: " +
                "\nId: " + id + " - " +
                "Name: " + name + " - " +
                "Price: " + price + " - " +
                "Amount: " + amount + " - " +
                "Category: " + category;
        }

        internal bool Equals(object v)
        {
            throw new NotImplementedException();
        }

    }
}
