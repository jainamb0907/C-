namespace types_of_constructor
{
    internal class Program
    {
        int num;
        string name;
        // data members of the class.
        int id;

        // this would be invoked while the object of that class created. 
        Program()
        {
            Console.WriteLine("Constructor Called");
        }

        // parameterized constructor would initialized data members with the values of passed arguments while object of that class created.
        Program(String name, int id)
        {
            this.name = name;
            this.id = id;
        }


        private string month;
        private int year;

        // declaring Copy constructor
        public Program(Program s)
        {
            month = s.month; //p4.month=p3.month
            year = s.year; //p4.year=p3.year
        }

        // Instance constructor
        public Program(int year, string month)
        {
            this.month = month; //private parameter month= argument june
            this.year = year; //private parameter year= argument 2018
        }

        // Get details of Program
        public string Details
        {
            get
            {
                return "Month: " + month.ToString() +
                         "\nYear: " + year.ToString();
            }
        }


        // It is invoked before the first instance constructor is run. 
        static Program()
        {

            // The following statement produces the first line of output, and the line occurs only once.
            Console.WriteLine("Static Constructor");
        }

        // Instance constructor.
        public Program(int i)
        {
            Console.WriteLine("Instance Constructor " + i);
        }

        // Instance method.
        public string program_detail(string name, int id)
        {
            return "Name:" + name + " id:" + id;
        }
        static void Main(string[] args)
        {
            // this would invoke default constructor.
            Program p1 = new Program();

            // Default constructor provides the default values to the int and object as 0, null
            // Note: It Give Warning because Fields are not assign
            Console.WriteLine(p1.name);
            Console.WriteLine(p1.num);



            // This will invoke parameterized constructor.
            Program p2 = new Program("GFG", 1);
            Console.WriteLine("GeekName = " + p2.name +
                             " and GeekId = " + p2.id);



            // Create a new Program object.
            Program p3 = new Program(2018, "June");

            // here is p3 details is copied to p4.
            Program p4 = new Program(p3);

            Console.WriteLine(p4.Details);



            // If you uncomment the following statement, it will generate an error because the constructor is unaccessible:
            // PrivateC s = new PrivateC(); // Error

            PrivateC.count_privatec = 99;

            // Accessing without any instance of the class 
            PrivateC.privatec_Count();

            Console.WriteLine(PrivateC.count_privatec);

            // Accessing without any instance of the class
            PrivateC.privatec_Count();

            Console.WriteLine(PrivateC.count_privatec);



            // Here Both Static and instance constructors are invoked for first instance
            Program obj = new Program(1);

            Console.WriteLine(obj.program_detail("GFG", 1));

            // Here only instance constructor will be invoked
            Program obj1 = new Program(2);

            Console.WriteLine(obj1.program_detail("GeeksforGeeks", 2));
        }
    }
}