using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Employee
{
    class Employee
    {

        public string Name { get; set; }
        public string Type { get; set; }
        public int Id { get; set; }

        public Employee(string name, string type, int id)
        {
            Name = name;
            Type = type;
            Id = id;
        }

    }
}
