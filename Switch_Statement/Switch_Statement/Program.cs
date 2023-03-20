using System.Linq.Expressions;
using System.Runtime.Intrinsics.X86;

namespace Switch_Statement
{
    internal class Program
    {

        static bool isOdd(int x)
        {
            switch (x % 2)
            {
                case 0:
                    return true;
                case 1:
                    return false;
            }

            return false;
        }
        static void Main(string[] args)
        {
            int nitem = 5;
            switch (nitem)
            {

                case 1:
                    Console.WriteLine("case 1");
                    break;

                case 5:
                    Console.WriteLine("case 5");
                    break;

                case 9:
                    Console.WriteLine("case 9");
                    break;

                default:
                    Console.WriteLine("No match found");
                    break;
            }


            //The switch statement can also include an expression whose result will be tested against each case at runtime.
            int x = 125;

            switch (x % 2)
            {
                case 0:
                    Console.WriteLine($"{x} is even value");
                    break;
                case 1:
                    Console.WriteLine($"{x} is odd Value");
                    break;
            }

            //Multiple cases can be combined to execute the same statements.
            int y = 5;

            switch (y)
            {
                case 1:
                    Console.WriteLine("y = 1");
                    break;
                case 2:
                    Console.WriteLine("y = 2");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("y = 4 or y = 5");
                    break;
                default:
                    Console.WriteLine("y > 5");
                    break;
            }

            //use the return keyword.
            Console.Write(isOdd(x) ? "Even value" : "Odd value");

            /*switch (x)
            {
                case 0:
                    Console.WriteLine($"{x} is even value");
                    break;
                case 125:
                    Console.WriteLine($"{x} is odd Value");
                    break;
                case 125: // Error - Control cannot fall through from one case label ('case 125:') to another
                    Console.WriteLine($"{x} is odd Value"); //The switch cases without break, return, or goto statement or with the same constant values would give a compile-time error.
                defaut:
                    Console.WriteLine($"{x} is odd Value");
                    break;
            }*/

            // use of goto in switch statement
            int greeting = 2;

            switch (greeting)
            {
                case 1:
                    Console.WriteLine("Hello");
                    goto default;
                case 2:
                    Console.WriteLine("Bonjour");
                    goto case 3;
                case 3:
                    Console.WriteLine("Namaste");
                    goto default;
                default:
                    Console.WriteLine("Entered value is: " + greeting);
                    break;
            }


            // Nested Switch Statements
            int j = 5;

            switch (j)
            {
                case 5:
                    Console.WriteLine(5);
                    switch (j - 1)
                    {
                        case 4:
                            Console.WriteLine(4);
                            switch (j - 2)
                            {
                                case 3:
                                    Console.WriteLine(3);
                                    break;
                            }
                            break;
                    }
                    break;
                case 10:
                    Console.WriteLine(10);
                    break;
                case 15:
                    Console.WriteLine(15);
                    break;
                default:
                    Console.WriteLine(100);
                    break;
            }
        }
    }
}