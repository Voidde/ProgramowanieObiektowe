using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02_zadanie
{
    class Seller : Person
    {
        public Seller(string name, int age) : base(name, age)
        {

        }

        public override string ToString()
        {
            return $"Seller : {base.ToString()}\n";

        }

        
    }
}
