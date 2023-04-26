namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 2;
            Console.WriteLine(x % y);

            x = 5;
            y = 3;
            Console.WriteLine(x == y);  // returns False because 5 is not equal to 3

            //Logical operators are used to determine the logic between variables or values
            x = 5;
            Console.WriteLine(x > 3 || x < 4); // returns True because one of the conditions are True (5 is greater than 3, but 5 is not less than 4)
        }
    }
}