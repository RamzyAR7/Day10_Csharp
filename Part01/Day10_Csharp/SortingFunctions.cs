using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Csharp
{
    internal class SortingFunctions
    {
        public static bool sort_2stp(Employee a, Employee b)
        {
            if (a == null || b == null)
            {
                throw new ArgumentNullException("Employee is null");
            }
            int salaryComparison = a.Salary.CompareTo(b.Salary);
            if (salaryComparison == 0)
            {
                return a.Name.CompareTo(b.Name) > 0;
            }
            return salaryComparison > 0;
        }
    }
}
