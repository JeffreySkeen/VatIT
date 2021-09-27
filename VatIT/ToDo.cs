using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VatIT
{
    public class ToDo
    {
        private readonly int id;
        private string name;
        private bool completed;
        public ToDo(string name, int id, bool completed)
        {
            this.id = id;
            this.name = name;
            this.completed = completed;
        }

        public static ToDo Create(string name, int ID, bool completed)
        {
            return new ToDo(name, ID, completed);
        }

        public bool Completed
        {
            get
            {
                return this.completed;
            }
            set
            {
                this.completed = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public int ID
        {
            get
            {
                return this.id;
            }
        }
    }
}
