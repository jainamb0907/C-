using System;

namespace Property_Encapsulation
{
    // Driver Class
    internal class Program
    {
        // Main Method
        static void Main(string[] args)
        {
            // creating object
            DemoEncap obj = new DemoEncap();

            Person myObj = new Person();
            myObj.Name = "Keyu";
            Console.WriteLine(myObj.Name);


            // calls set accessor of the property Name, and pass "Jainam" as value of the standard field 'value'
            obj.Name = "Jainam";

            // calls set accessor of the property Age, and pass "21" as value of the standard field 'value'
            obj.Age = 21;

            // Displaying values of the variables
            Console.WriteLine("Name: " + obj.Name);
            Console.WriteLine("Age: " + obj.Age);
        }
    }
}