using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02_zadanie
{
    class Meat : Product
    {
        private double weight;

        public double Weight { get => this.weight; }

        public Meat(string name, double weight) : base(name)
        {
            this.weight = weight;
        }

        public override string ToString()
        {
            return $"{base.ToString()} ({weight} kg)";

        }

    }
}
