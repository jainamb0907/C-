using System.Xml.Linq;

namespace Methods
{
    class Program
    {
        // method declaration
        static int addNumbers()
        {
            int sum = 5 + 14;
            return sum;
            //return 5+14;
        }

        static void MyMethod(string country = "Norway") //country is an optional parameter 
        {
            Console.WriteLine(country);
        }

        static void Named_Arguments(string child1, string child2, string child3)
        {
            Console.WriteLine("The youngest child is: " + child3);
        }

        // method with one int parameter
        void display(int a)
        {
            Console.WriteLine("int type Arguments: " + a);
        }

        // method with string parameter
        void display(string b)
        {
            Console.WriteLine("string type: " + b);
        }

        // method with two parameters
        void display(int a, int b)
        {
            Console.WriteLine("Arguments: " + a + " and " + b);
        }

        // method with int and string parameters 
        void display(int a, string b)
        {
            Console.WriteLine("int: " + a);
            Console.WriteLine("string: " + b);
        }

        // method with string and int parameter
        void display(string b, int a)
        {
            Console.WriteLine("string: " + b);
            Console.WriteLine("int: " + a);
        }

        static void Main(string[] args)
        {
            // call method 
            int sum = addNumbers();
            Console.WriteLine(sum);
            //Console.WriteLine(addNumbers());

            MyMethod(); //default argument
            MyMethod("USA");

            Named_Arguments(child3: "John", child1: "Liam", child2: "Liam");

            Program p1 = new Program();
            p1.display(100);
            p1.display("Programiz");
            p1.display(100, 200);
            p1.display(100, "Programming");
            p1.display("Programiz", 400);
        }
    }
}


