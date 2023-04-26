using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace async_await_task
{
    // Synchronous program
    internal class SP
    {
        public void SomeMethod()
        {
            Console.WriteLine("Some Synchronous program Method Started......");

            //some code that takes long execution time
            //Thread.Sleep() is a synchronous method
            Thread.Sleep(TimeSpan.FromSeconds(10)); // hold execution for 10 seconds
            // System.Threading.Thread.Sleep(4000); // hold execution for 4 seconds

            Console.WriteLine("\n");
            Console.WriteLine("Some Synchronous program Method End");
        }
    }
}
