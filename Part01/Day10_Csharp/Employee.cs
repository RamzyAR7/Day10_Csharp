using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Csharp
{
    internal class Employee : IComparable<Employee>, ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int _id, string _name, double _salary)
        {
            Id = _id;
            Name = _name;
            Salary = _salary;
        }
        public override string ToString()
        {
            return $"EmpId {Id}, EmpName {Name}, EmpSalary {Salary}";
        }

        public int CompareTo(Employee other)
        {
            if(other == null) throw new ArgumentNullException("other");

            if(Salary > other.Salary) return 1;
            else if(Salary < other.Salary) return -1;
            else return 0;
        }

        public object Clone()
        {
            return new Employee(Id, Name, Salary);
        }
    }
}
