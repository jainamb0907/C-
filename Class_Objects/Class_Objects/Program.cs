using System.Diagnostics;

namespace Class_Objects
{
    internal class Program // The class
    {
        static void Main(string[] args)
        {
            Car myObj1 = new Car();
            Car myObj2 = new Car();
            myObj2.seats = 5;
            Console.WriteLine(myObj1.color);
            Console.WriteLine(myObj2.seats);
            myObj1.fullThrottle(); // Call the method


            Car Ford = new Car();
            Ford.model = "Mustang";
            Ford.year = 1969;

            Car Opel = new Car();
            Opel.model = "Astra";
            Opel.color = "white";
            Opel.year = 2005;

            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.color);
        }
    }

}