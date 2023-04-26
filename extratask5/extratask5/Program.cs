namespace extratask5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                " Please Enter the Day Number 1 to 7 (Consider 1= Monday, and 7 = Sunday) :  "
            );
            int weekday = int.Parse(Console.ReadLine());

            switch (weekday)
            {
                case 1:
                    Console.WriteLine("\n Today is Monday");
                    break;
                case 2:
                    Console.WriteLine("\n Today is Tuesday");
                    break;
                case 3:
                    Console.WriteLine("\n Today is Wednesday");
                    break;
                case 4:
                    Console.WriteLine("\n Today is Thursday");
                    break;
                case 5:
                    Console.WriteLine("\n Today is Friday");
                    break;
                case 6:
                    Console.WriteLine("\n Today is Saturday");
                    break;
                case 7:
                    Console.WriteLine("\n Today is Sunday");
                    break;
                default:
                    Console.WriteLine("\n Please enter Valid Number between 1 to 7");
                    break;
            }
        }
    }
}
