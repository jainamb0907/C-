using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace async_await_task
{
    internal class AP
    {
        public async void SomeMethod()
        {
            Console.WriteLine("Some Asynchronous program Method Started......");

            await Task.Delay(TimeSpan.FromSeconds(10));
            Console.WriteLine("\n");
            Console.WriteLine("Some Asynchronous program Method End");
        }
    }
}
