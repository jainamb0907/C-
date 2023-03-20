using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace partial_class
{
    public partial class Employee
    {
        partial void GenerateEmployeeId(int id)
        {
            this.EmpId = id;
        }

        static void Main(string[] args)
        {
            var emp = new Employee();
            Console.WriteLine(emp.EmpId); // prints genereted id
        }
    }

    public partial class Geeks
    {
        private string Author_name;
        private int Total_articles;

        public Geeks(string a, int t)
        {
            this.Author_name = a;
            this.Total_articles = t;
        }
    }
}
