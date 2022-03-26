using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02_zadanie
{
    class Fruit : Product
    {
        private int count;

        public int Count { get => this.count; }

        public Fruit(string name, int count) : base(name)
        {
            this.count = count;
        }

        public override string ToString()
        {
            return $"{base.ToString()} ({count} fruits)";
        }

        

    }
}
