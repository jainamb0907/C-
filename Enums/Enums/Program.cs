using static System.Net.Mime.MediaTypeNames;

namespace Enums
{
    enum Level
    {
        Low,
        Medium,
        High
    }

    enum Months
    { 
        //You can also assign your own enum values, and the next items will update their numbers accordingly
        January,    // 0
        February,   // 1
        March=6,      // 6
        April,      // 7
        May=February+2,        // 8
        June,       // 9
        July        // 10
    }

    enum Button : byte
    {

        // OFF denotes the Button is switched Off... with value 0
        OFF,

        // ON denotes the Button is switched on.. with value 1
        ON

    }

    class Program
    {
        enum Temp
        {
            Low,
            Medium,
            High
        }
        static void Main(string[] args)
        {
            int myNum = (int)Months.May;
            Console.WriteLine(myNum);

            Console.WriteLine(Level.Medium);
            Console.WriteLine(Temp.Low);
            Level myVar = Level.Medium;
            switch (myVar)
            {
                case Level.Low:
                    Console.WriteLine("Low level");
                    break;
                case Level.Medium:
                    Console.WriteLine("Medium level");
                    break;
                case Level.High:
                    Console.WriteLine("High level");
                    break;
            }

            Console.WriteLine("Enter 0 or 1 to know the " +
                       "state of electric switch!");

            byte i = Convert.ToByte(Console.ReadLine());

            if (i == (byte)Button.OFF)
            {

                Console.WriteLine("The electric switch is Off");
            }

            else if (i == (byte)Button.ON)
            {
                Console.WriteLine("The electric switch is ON");
            }

            else
            {
                Console.WriteLine("byte cannot hold such" +
                                          " large value");
            }

        }
    }
}