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
            string result = $"Buyer: {base.ToString()}\n";
            if (tasks.Any())
            {
                result += "\t\t-- Products: --\n";
                for (int i = 0; i < tasks.Count; i++)
                {
                    result += $"\t\t{tasks[i]}\n";
                }

            }

            return result;
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
