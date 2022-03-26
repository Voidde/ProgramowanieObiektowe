using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02_zadanie
{
    abstract class Product : IThing
    {
        private string name;

        public string Name { get => this.name; }

        public Product(string name) => this.name = name;

        public override string ToString()
        {
            return $"{name}".ToString();

        }
        virtual public void Print()
        {
            ToString();
        }
    }
}

