using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Inheritance
{
    class Child : Parent  // Derived class
    {
        public string modelName = "Mustang";  // Car field
    }

    // inheriting the GFG class using :
    class GeeksforGeeks : GFG
    {

        // constructor of derived class
        public GeeksforGeeks()
        {
            Console.WriteLine("GeeksforGeeks");
        }
    }
}
