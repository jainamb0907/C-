using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace types_of_constructor
{
    public class PrivateC
    {
        // declare private Constructor
        private PrivateC()
        {
        }

        // declare static variable field
        public static int count_privatec;

        // declare static method
        public static int privatec_Count()
        {
            return ++count_privatec;
        }
    }
}
