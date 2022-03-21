﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02
{
 

    class Teacher:Person
    {
        public Teacher(string name, int age) : base(name, age)
        {
            this.name = name;
            this.age = age;
        }
        public override string ToString()
        {
            return $"Teacher : {base.ToString()}";
        }
    }
}