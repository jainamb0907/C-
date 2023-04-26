using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace partial_class
{
    public partial class Employee
    {
        public Employee()
        {
            int id = 13;
            GenerateEmployeeId(id);
        }

        public int EmpId { get; set; }
        public string Name { get; set; }

        partial void GenerateEmployeeId(int id);
    }
}
