using System;
using System.Reflection;

namespace Practical3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*---Inheritance---*/
            Console.WriteLine("---Inheritance---");

            Team team = new Team();
            string cString = team.printInfo();
            Console.WriteLine(cString);

            /*---Polymorphism---*/
            Console.WriteLine("---Polymorphism---");

            Bird myBird = new Bird();

            //Duck myDuck = new Bird();
            /*
            Output:
            Error	CS0266	Cannot implicitly convert type 'Practical3.Bird' to 'Practical3.Duck'. An explicit conversion exists (are you missing a cast?) At line 12
            Reason: We can't create a base class object from derived class in c#
            */

            // Solution: Created object of Child class "Duck" using its parent class "Bird"
            Bird myDuck = new Duck();

            myBird.Voice(); // Invoking the Voice method of Bird class
            myDuck.Voice(); // Invoking the Voice method of Duck class

            /*---Encapsulation---*/
            Console.WriteLine("---Encapsulation---");
            // creating object
            Laptop lap = new Laptop();
            lap.Brand = "HP";
            lap.Model = 678798;

            //Console.WriteLine("Laptop brand: "+lap.Brand);
            //Console.WriteLine("Model number of laptop: " + lap.Model);
            lap.LaptopDetails();
            lap.MotherBoardInfo();
        }
    }
}
