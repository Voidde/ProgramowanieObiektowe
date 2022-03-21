using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02
{
    class Student : Person
    {
        protected string group;
        protected List<Task> tasks;

        public string Group { get => this.group; }

        public Student(string name, int age, string group) : this(name, age, group, new List<Task>())
        {
            this.group = group;
        }



        public Student(string name,int age, string group,List<Task> tasks) : base(name, age)
        {
            this.group = group;
            this.tasks = tasks;
        }
        public override string ToString()
        {
            string result = $"Student : {base.ToString()}\n";
            result += $"Group: {group} \n";
            result += $"Tasks: \n";
                for (int i = 0; i < tasks.Count; i++)
            {
                result+= $"{tasks} \n";
            }
                
            return result;
        }
        internal void AddTask(string taskName, TaskStatus taskStatus)
        {
            
        }
        internal void UpdateTask(int v, TaskStatus done)
        {
            
        }

    }


}
