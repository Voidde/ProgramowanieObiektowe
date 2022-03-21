using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02_zadanie
{
    class Buyer : Person
    {
        protected List<Product> tasks = new List<Product>();

        public Buyer(string name, int age) : base(name, age)
        {

        }

        public override string ToString()
        {
            return $"Buyer : {base.ToString()}";
        }



        internal void AddProduct(Product product)
        {
            tasks.Add(product);
        }

        internal void RemoveProduct(int index)
        {
            tasks.RemoveAt(index);
        }
    }
}
