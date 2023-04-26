using System;

namespace Multithreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ----Signle threading---- */
            // create a new thread
            Console.WriteLine("----Signle threading----");
            Thread t = new Thread(Worker1); // Worker method is executed in a separate thread

            // start the thread
            t.Start();

            // do some other work in the main thread
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread Worker1 Main thread doing some work");
                Thread.Sleep(100);
            }

            // wait for the worker thread to complete
            t.Join();

            Console.WriteLine("Done");

            // queue a work item to the thread pool
            ThreadPool.QueueUserWorkItem(Worker2, "Hello, world!");

            // do some other work in the main thread
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadPool Worker2 Main thread doing some work");
                Thread.Sleep(100);
            }

            Console.WriteLine("Done");

            Console.WriteLine();   
            Console.WriteLine("----Multiple threading----");
            // Creating and initializing threads
            Thread thr1 = new Thread(method1);
            Thread thr2 = new Thread(method2);
            thr1.Start();
            thr2.Start();
        }

        static void Worker1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Worker thread doing some work");
                Thread.Sleep(100);
            }
        }

        static void Worker2(object state)
        {
            string message = (string)state;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(message);
                Thread.Sleep(100);
            }
        }

        // static method one
        public static void method1()
        {
            // It prints numbers from 0 to 10
            for (int I = 0; I <= 10; I++)
            {
                Console.WriteLine("Method1 is : {0}", I);

                // When the value of I is equal to 5 then
                // this method sleeps for 6 seconds
                if (I == 5)
                {
                    Thread.Sleep(6000);
                }
            }
        }

        // static method two
        public static void method2()
        {
            // It prints numbers from 0 to 10
            for (int J = 0; J <= 10; J++)
            {
                Console.WriteLine("Method2 is : {0}", J);
            }
        }
    }
}
