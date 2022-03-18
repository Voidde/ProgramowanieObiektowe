using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02
{
    public enum TaskStatus
    {
        Waiting,
        Progress,
        Done,
        Rejected,
    }
    class Task
    {
        private string name;

        private TaskStatus status;

        public string Name { get => this.name; }

        public TaskStatus Status { get => this.status; }

        public Task(string name, TaskStatus status)
        {
            this.name = name;
            this.status = status;
        }

        public override string ToString()
        {
            return $"{name} [{status}]".ToString();
        }

        public bool Equals(Task other)
        {
            if (other == null) return false;
            if (other == this) return true;

            return Task.Equals(this.name, this.status) && Task.Equals(other.name, other.status); 
        }
    }
}
