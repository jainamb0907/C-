// C# Program to show use of access modifier Inside the file Program.cs
using System;

namespace Access_Modifiers
{
    // Driver Class
    class Program
    {
        private string model = "Mustang";

        static void Main(string[] args) // Main Method
        {
            Program myObj = new Program();
            Console.WriteLine(myObj.model); //private


            X obj1 = new X();
            Y obj2 = new Y();

            // Displaying the value of x
            Console.WriteLine("Value of x is : {0}", obj2.getX()); //protected


            // Instantiate the class Complex in separate class but within the same assembly
            Complex c = new Complex(); //internal

            // Accessible in class Program
            c.setData(2, 1);
            c.displayData();
        }
    }


    class X
    {

        // Member x declared as protected
        protected int x;

        public X()
        {
            x = 10;
        }
    }

    // class Y inherits the class X
    class Y : X
    {

        // Members of Y can access 'x'
        public int getX()
        {
            return x;
        }
    }

    // Declare class Complex as internal
    internal class Complex
    {

        int real;
        int img;

        public void setData(int r, int i)
        {
            real = r;
            img = i;
        }

        public void displayData()
        {
            Console.WriteLine("Real = {0}", real);
            Console.WriteLine("Imaginary = {0}", img);
        }
    }

}
