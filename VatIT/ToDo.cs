using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VatIT
{
    public class ToDo
    {
        private readonly int ID;
        private string name;
        private bool completed;
        public ToDo(string name, int ID, bool completed)
        {
            this.ID = ID;
            this.name = name;
            this.completed = completed;
        }

        public static ToDo Create(string name, int ID, bool completed)
        {
            return new ToDo(name,ID,completed);
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
                return this.Name;
            }
            set
            {
                this.name = value;
            }
        }
}
