using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02_zadanie
{
    class Shop
    {
        private string name;

        private Person[] persons;

        private Product[] products;

        public string Name { get => this.name; }

        public Shop(string name, Person[] persons, Product[] products)
        {
            name = this.name;
            persons = this.persons;
            products = this.products;
        }

        public override string ToString()
        {
            string result = $"Shop: {this.name} \n";
            result += "-- People: --\n";


            for (int i = 0; i < persons.Length; i++)
            {
                result += $"{persons[i]}";
            }

            result += "-- Products: --";

            for (int i = 0; i < products.Length; i++)
            {
                result += $"{products[i]}";
            }


                return result;
        }

        internal void Print()
        {
            string result = $"Shop: {this.name} \n";
            result += "-- People: --\n";


            for (int i = 0; i < persons.Length; i++)
            {
                result += $"{persons[i]}";
            }

            result += "-- Products: --";

            for (int i = 0; i < products.Length; i++)
            {
                result += $"{products[i]}";
            }


            Console.WriteLine(result);
        }
    }
}
