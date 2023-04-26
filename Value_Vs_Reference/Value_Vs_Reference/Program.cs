namespace Value_Vs_Reference
{
    internal class Program
    {
        static void Enroll(Student student)
        {
            student.Enrolled = true; // This changes the student variable that was passed in outside of the method.
            Console.WriteLine("Student enrollment Status: " + student.Enrolled);
            student = new Student(); // This does not change the student variable outside of the method but creates a new reference. Since student now points to a new reference, the student variable outside of the method is no longer affected after this line.
            student.Enrolled = false; // This changes the local student inside the method.
            Console.WriteLine("Student enrollment Status: " + student.Enrolled);
        }

        static void Enroll(bool enrollmentStatus)
        {
            // This will not change any value outside the method.
            enrollmentStatus = true;
            Console.WriteLine("Student enrollment Status: " + enrollmentStatus);
        }

        static void Main(string[] args)
        {
            var student = new Student { Name = "Susan", Enrolled = false };

            // pass by value(generate copy of the variable)
            Enroll(student.Enrolled); // student.Enrolled still equals false.
            Console.WriteLine(
                "Main pass by value not effect the original variable, Student enrollment Status: "
                    + student.Enrolled
            );

            // pass by reference
            Enroll(student); // student.Name is still Susan, student.Enrolled is now true
            Console.WriteLine(
                "Main pass by reference will effect the original object, Student enrollment Status: "
                    + student.Enrolled
            );
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public bool Enrolled { get; set; }
    }
}
