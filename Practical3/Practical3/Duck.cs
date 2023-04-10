using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Practical3
{
    // Derived class
    internal class Duck : Bird // Extend parent class
    {
        public override void Voice()
        {
            Console.WriteLine("The Duck says: Quack Quack");
        }
    }
}
