using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
namespace ConsoleApp1
{
    class Category : IComparable<Category>
    {
        public int id { get; set; }
        public String name { get; set; }

        public Category(int id, String name)
        {
            this.id = id;
            this.name = name;
        }

        

        public int CompareTo(Category other)
        {
            return name.CompareTo(other.name);
        }

        public override string ToString()
        {
            return "\nCategory: " +
                "\nId: " + id + " - " +
                "Name: " + name;
        }
    }
}