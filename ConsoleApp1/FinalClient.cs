using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApp1
{
    class FinalClient
    {
        public int cuil { get; set; }

        public FinalClient(int cuil)
        {
            this.cuil = cuil;
          
        }

        public override string ToString()
        {
            return "\nFinalClient: " +
                "\nCuil: " + cuil;
        }

    }
}