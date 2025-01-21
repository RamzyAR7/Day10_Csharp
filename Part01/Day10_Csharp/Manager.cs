using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Csharp
{
    internal class Manager : Employee, IComparable<Manager>, ICloneable
    {
        public Manager(int _id, string _name, double _salary) : base(_id, _name, _salary)
        {

        }
        public int CompareTo(Manager other)
        {
            if (other == null) throw new ArgumentNullException("other");

            if (Salary > other.Salary) return 1;
            else if (Salary < other.Salary) return -1;
            else return 0;
        }
    }
}
