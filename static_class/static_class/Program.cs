using System.Diagnostics;

namespace static_class
{
    static class Author
    {
        // Static data members of Author
        public static string A_name = "Ankita";
        public static string L_name = "CSharp";
        public static int T_no = 84;

        // Static method of Author
        public static void details()
        {
            Console.WriteLine("The details of Author is:");
        }
    }

    public class StopWatch
    {
        public static int NoOfInstances = 0;

        // static constructor
        static StopWatch()
        {
            Console.WriteLine("Static constructor called");
        }

        // instance constructor
        public StopWatch()
        {
            StopWatch.NoOfInstances++;
            Console.WriteLine("Instance constructor called");
        }

        // static method
        public static void DisplayInfo()
        {
            Console.WriteLine("DisplayInfo called");
        }

        // instance method
        public void Start() { }

        // instance method
        public void Stop() { }
    }

    public class Program
    {
        static int counter = 0;
        string name = "Demo Program";

        static void Display(string text)
        {
            Console.WriteLine(text);
        }

        public void SetRootFolder(string path) { }

        static void Main(string[] args)
        {
            // Calling static method of Author
            Author.details();

            // Accessing the static data members of Author
            Console.WriteLine("Author name : {0} ", Author.A_name);
            Console.WriteLine("Language : {0} ", Author.L_name);
            Console.WriteLine("Total number of articles : {0} ", Author.T_no);

            StopWatch.DisplayInfo(); // static constructor called here
            StopWatch.DisplayInfo(); // none of the constructors called here

            StopWatch sw1 = new StopWatch(); // First static constructor and then instance constructor called
            StopWatch sw2 = new StopWatch(); // only instance constructor called
            StopWatch.DisplayInfo();
            Console.WriteLine(StopWatch.NoOfInstances); //Static fields of a non-static class is shared across all the instances

            StopWatch sw3 = new StopWatch();
            StopWatch sw4 = new StopWatch();
            Console.WriteLine(StopWatch.NoOfInstances);

            counter++; // can access static fields
            Display("Hello World!"); // can call static methods

            /*
            name = "New Demo Program"; //Error: cannot access non-static members
            SetRootFolder("C:\MyProgram"); //Error: cannot call non-static method
            */
        }
    }
}
