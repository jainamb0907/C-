using System;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a myCar object
            Child myCar = new Child();

            // Call the honk() method (From the Vehicle class) on the myCar object
            myCar.honk();

            // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
            Console.WriteLine(myCar.brand + " " + myCar.modelName);

            // creating object of derived class
            GeeksforGeeks g = new GeeksforGeeks();

            // calling the method of base class using the derived class object
            g.readers("Kirti", "C#");
        }
    }
}