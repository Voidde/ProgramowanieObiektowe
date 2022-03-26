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
<<<<<<< HEAD
            return $"Seller : {base.ToString()}\n";
=======
            return $"Seller: {base.ToString()}\n";
>>>>>>> fb6d5d36e6e6f78d6d387ba377c9461b6fa95b1e
        }


    }
}
