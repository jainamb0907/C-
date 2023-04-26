using System.Diagnostics;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "JD";
            string lastName = "Bhavsar";
            string name = string.Concat(firstName, lastName);
            Console.WriteLine(name);

            //Better
            name = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name);

            //access the characters in a string by referring to its index
            string myString = "Hello";
            Console.WriteLine(myString[myString.Length - 1]);
            Console.WriteLine(myString.IndexOf("e"));

            // Full name
            name = "JainAm Bhavsar";

            // Location of the letter D
            int charPos = name.IndexOf("A");

            // Get last name
            lastName = name.Substring(charPos);

            // Print the result
            Console.WriteLine(lastName);
            Console.WriteLine(name);

            Console.WriteLine(10 > 9);
        }
    }
}