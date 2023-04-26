using System.Dynamic;
using System.Net.NetworkInformation;

namespace If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10, j = 20;

            if (i > j)
            {
                Console.WriteLine("i is greater than j");
            }

            if (i < j)
            {
                Console.WriteLine("i is less than j");
            }

            if (i == j)
            {
                Console.WriteLine("i is equal to j");
            }

            // Declaring and initializing variables
            int x1 = 15;
            int x2 = 18;
            int x3 = 20;

            // If statement Using AND operator 
            if (x1 > 20 && x2 > 20)
            {
                Console.WriteLine("Enter group A");
            }

            // If statement Using OR operator
            if (x1 < 30 || x3 == 20)
            {
                Console.WriteLine("Enter group B");
            }

            // If statement Using NOT operator
            if (!(x1 > 20 && x2 > 20))
            {
                Console.WriteLine("Enter group C");
            }

            //Calling Function as Condition
            if (isGreater(i, j))
            {
                Console.WriteLine("i is less than j");
            }

            if (isGreater(j, i))
            {
                Console.WriteLine("j is greater than i");
            }
            static bool isGreater(int i, int j)
            {
                return i > j;
            }
        }
    }
}