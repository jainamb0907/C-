namespace ref_out_in
{
    internal class Program
    {
        static void Enroll(ref Student student)
        {
            Console.WriteLine("ref Enroll, student enrollment status: " + student.Enrolled);
            // With ref, all three lines below alter the student variable outside the method.
            student.Enrolled = true;
            Console.WriteLine("ref Enroll, student enrollment status: " + student.Enrolled);
            student = new Student();
            student.Enrolled = false;
            Console.WriteLine("ref Enroll, student enrollment status: " + student.Enrolled);
        }

        static void IncrementExample(ref int num)
        {
            num = num + 1; //reflect value types outside the method as well
        }

        static void EnrollOut(out Student so)
        {
            //We need to initialize the variable in the method before we can do anything
            so = new Student();
            Console.WriteLine("out EnrollOut, student enrollment status: " + so.Enrolled);
            so.Enrolled = true;
            Console.WriteLine("out EnrollOut, student enrollment status: " + so.Enrolled);
        }

        static void EnrollIn(in Student si)
        {
            // With in assigning a new object would throw an error
            // student = new Student();
            Console.WriteLine("in EnrollIn, student enrollment status: " + si.Enrolled);
            // We can still do this with reference types though
            si.Enrolled = true;
            Console.WriteLine("in EnrollIn, student enrollment status: " + si.Enrolled);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("----ref modifier modifier with reference types----");
            var student = new Student { Name = "Susan", Enrolled = false };
            Console.WriteLine("Before ref Main, Student name: " + student.Name);
            Console.WriteLine("Before ref Main, student enrollment status: " + student.Enrolled);
            Enroll(ref student);
            Console.WriteLine("After ref Main, Student Name: " + student.Name); // student.Name is now null since a value was not passed when declaring new Student() in the Enroll method
            Console.WriteLine("After ref Main, student enrollment status: " + student.Enrolled); // student.Enrolled is now false due to the ref modifier

            // Console.WriteLine("----ref modifier modifier with value types----");
            int num = 1;
            IncrementExample(ref num); // num is now 2

            Console.WriteLine();
            Console.WriteLine("----out modifier modifier with reference types----");
            Student so; // Declared object "so" of the Student class

            EnrollOut(out so); // so will be equal to the value in EnrollOut.
            Console.WriteLine("After out Main, Student Name: " + so.Name); // so.Name is now null since a value was not passed when declaring new Student() in the EnrollOut method
            Console.WriteLine("After out Main, Student enrollment status: " + so.Enrolled); // so.Enrolled is now false due to the out modifier

            // Console.WriteLine("----out modifier modifier with value types----");
            //int x;
            //Int32.TryParse("3", out x);

            Console.WriteLine();
            Console.WriteLine("----in modifier modifier with reference types----");
            var si = new Student { Name = "Susan", Enrolled = false };

            Console.WriteLine("Before in Main, Student name: " + si.Name);
            Console.WriteLine("Before in Main, student enrollment status: " + si.Enrolled);

            EnrollIn(si);

            Console.WriteLine("After in Main, Student Name: " + si.Name); // si.Name is Susan
            Console.WriteLine("After in Main, student enrollment status: " + si.Enrolled); // si.Enrolled is now True due to the in modifier
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public bool Enrolled { get; set; }
    }
}
