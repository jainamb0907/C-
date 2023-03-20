namespace Forloop
{
    internal class Program
    {
        static void Main(string[] args)
        { //An Initializer, condition, and iterator sections are optional. You can initialize a variable before for loop, and condition and iterator can be defined inside a code block.
            int i = 0;

            for (; ; )
            {
                if (i < 10)
                {
                    Console.WriteLine("Value of i: {0}", i);
                    i++;
                }
                else
                    break;
            }

            for (i = 0; i < 10; i++)
                Console.WriteLine("Value of i: {0}", i); //a single statement

            /*
            // never ending loop.
            for (; ; )
            {
                Console.Write(1);
            }

            for (double d = 1.01D; d < 1.10; d += 0.01D)
            {
                Console.WriteLine("Value of i: {0}", d);
            }*/

            //The control variable for the for loop can be of any numeric data type
            for (double d = 1.01D; d < 1.10; d += 0.01D)
            {
                Console.WriteLine("Value of i: {0}", d);
            }

            // Initializer and Iterator Statements
            i = 0;
            int j = 5;
            for (
                Console.WriteLine($"Initializer: i={i}, j={j}");
                i++ < j--;
                Console.WriteLine($"Iterator: i={i}, j={j}")
            ) { }

            //Multiple Expressions
            int k = 0;
            for (j = 0; k + j < 5; k++, j++)
            {
                Console.WriteLine("Value of K: {0}, J: {1} ", k, j);
            }

            // Nested for loop
            for (i = 0; i < 2; i++)
            {
                for (j = i; j < 4; j++)
                    Console.WriteLine("Value of i: {0}, J: {1} ", i, j);
            }
        }
    }
}
