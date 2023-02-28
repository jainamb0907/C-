using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Inheritance
{
    /* sealed: If you don't want other classes to inherit from a class, use the sealed keyword */
    class Parent  // Base class
    {
        public string brand = "Ford";  // Vehicle field
        public void honk()             // Vehicle method 
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }


    // Base class
    class GFG
    {
        // data members
        public string name;
        public string subject;

        // public method of base class
        public void readers(string name, string subject)
        {
            this.name = name;
            this.subject = subject;
            Console.WriteLine("Myself: " + name);
            Console.WriteLine("My Favorite Subject is: " + subject);
        }
    }
}
