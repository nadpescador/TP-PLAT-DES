using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp1
{
    class Purchase : IComparable<Purchase>
    {
        public int id { get; set; }
        public double total { get; set; }
        public Dictionary<Product, int> products { get; set; }
        public User buyer { get; set; }
        
        public Purchase(int id, double total, User buyer, Dictionary<Product, int> products)
        {
            this.id = id;
            this.total = total;
            this.buyer = buyer;
            this.products = products;
        }

        public int CompareTo(Purchase other)
        {
            return id.CompareTo(other.id);
        }

        public override string ToString()
        {
            return "\nPurchase: " +
                "\nId: " + id + " - " +
                "Total: " + total + " - " +
                "Buyer: " + buyer + " - " +
                "Products: " + products;
        }

    }
}