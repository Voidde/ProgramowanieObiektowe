using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02
{
    class Classroom
    {
        private string name;

        private Person[] persons;

        public string Name { get => this.name; }

        public Classroom(string name, Person[] persons)
        {
            this.name = name;
            this.persons = persons;
        }
        public override string ToString()
        {
            return $"Classroom: {this.name}".ToString();
        }
    }
}
