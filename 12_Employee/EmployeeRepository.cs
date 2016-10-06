using System.Collections.Generic;
using System;
using System.Linq;

namespace _12_Employee
{
    internal class EmployeeRepository
    {
        public int count { get; set; }

        public int Id { get; set; }

        Dictionary<int, Employee> dic = new Dictionary<int, Employee>();

        public Employee CreateEmployee(string name, string type)
        {
            count++;
            nextId();
            return new Employee(name, type, Id);
        }

        public void SaveEmployee(Employee em)
        {
            if (dic.ContainsKey(em.Id))
            {
                dic[em.Id] = em;
            }
            else
            {
                dic.Add(em.Id, em);
            }
        }

        public Employee LoadEmployee(int i)
        {

            return dic[i];
        }

        public List<Employee> FindAllEmployees()
        {

            return dic.Values.ToList();
        }

        public void nextId()
        {
            Id++;
        }

        public int CountEmployees()
        {
            return count;
        }

        public void Clear()
        {
            count = 0;
        }



    }
}