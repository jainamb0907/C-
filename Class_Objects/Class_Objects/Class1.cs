using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Class_Objects
{
    internal class Car // The class
    {
        // Class members
        public string model;
        public int year;
        public string color = "red"; // field
        public int seats; //You can also leave the fields blank, and modify them when creating the object, This is especially useful when creating multiple objects of one class
        public void fullThrottle()   // method
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
        
    }
}
