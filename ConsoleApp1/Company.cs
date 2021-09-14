using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Company
    {
        public int cuit { get; set; }

        public Company(int cuit)
        {
            this.cuit = cuit;
        }

        public override string ToString()
        {
            return "\nCompany: " +
                "\nCuit: " + cuit ;
        }
    }
}
