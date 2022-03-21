using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02_zadanie
{
    class Person
    {
        private string name;

        private int age;

        public string Name { get => this.name; }

        public int Age { get => this.age; }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return $"{name} ({age} y.o)".ToString();
        }
        internal void Print()
        {
            ToString();
        }
    }
}
