using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 9.78;
            int b = (int)a;  // Manual casting: double to int

            Console.WriteLine(a);
            Console.WriteLine(b);

            //convert data types explicitly by using built-in methods
            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;
            //string c = "jd";
            //Console.WriteLine((int)c);

            Console.WriteLine("Convert int to string: "+Convert.ToString(myInt));    // Convert int to string
            Console.WriteLine("Convert int to double: "+ Convert.ToDouble(myInt));    // Convert int to double
            Console.WriteLine("Convert double to int: " + Convert.ToInt32(myDouble));  // Convert double to int
            Console.WriteLine("Convert bool to string: " + Convert.ToString(myBool));   // Convert bool to string
        }
    }
}


