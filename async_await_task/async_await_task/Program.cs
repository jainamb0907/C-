using System.Threading;

namespace async_await_task
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Main Method Started......");
            SP sp = new SP();
            sp.SomeMethod();
            AP ap = new AP();
            ap.SomeMethod();
            Console.WriteLine("Main Method End");

            Task<int> result1 = LongProcess1();
            ShortProcess1();
            var val1 = await result1; // will stop the main thread there until it gets the return value populated in the result
            Console.WriteLine("Result val1: {0}", val1);

            Task<int> result2 = LongProcess2();
            Task<int> result3 = LongProcess3();
            // await result1 and await result2 just before we need to pass the return value to another method
            Console.WriteLine("After 2nd & 3rd long processes.");
            int val2 = await result2; // wait until get the return value
            DisplayResult(val2);
            val2 = await result3; // wait until get the return value
            DisplayResult(val2);
        }

        static async Task<int> LongProcess1() // Task<int> is used to indicate the return value type int
        {
            Console.WriteLine("LongProcess1 Started");
            await Task.Delay(4000); // hold execution for 4 seconds
            Console.WriteLine("LongProcess1 Completed");
            return 10;
        }

        static void ShortProcess1()
        {
            Console.WriteLine("ShortProcess1 Started");
            //do something here
            Console.WriteLine("ShortProcess1 Completed");
        }

        static async Task<int> LongProcess2()
        {
            Console.WriteLine("LongProcess 2 Started");
            await Task.Delay(4000); // hold execution for 4 seconds
            Console.WriteLine("LongProcess 2 Completed");
            return 20;
        }

        static async Task<int> LongProcess3()
        {
            Console.WriteLine("LongProcess 3 Started");
            await Task.Delay(4000); // hold execution for 4 seconds
            Console.WriteLine("LongProcess 3 Completed");
            return 30;
        }

        static void DisplayResult(int val2)
        {
            Console.WriteLine("Result value: {0}", val2);
        }
    }
}
