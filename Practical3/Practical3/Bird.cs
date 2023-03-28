using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Practical3
{
    internal class Bird // Parent class
    {
        public virtual void Voice()
        {
            Console.WriteLine("The Bird says: Turr Turrrrr");
        }
    }
}
