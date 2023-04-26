//to do:
//    uppeeracse, lowercase
//    enter name and marks for only once
//    student array
// user input validation


using System.Diagnostics;
using System.Reflection.Emit;
using System.ComponentModel.Design;

namespace Practical4
{
    internal class Program
    {
        enum Options
        {
            Aggregate = 1,

            MinMark = 2,

            MaximumMark = 3,
            Grade = 4
        }

        static void Main(string[] args)
        {
            Student student = new Student();
            //Console.WriteLine("How many students are there?");
            //int number=Convert.ToInt32(Console.ReadLine());
            //for(int i=0;i<number;i++)
            //{
            //    student.CalculateAverageMarks();
            //}


            Menu:
            Console.WriteLine("-----Menu for the User-----");
            Console.WriteLine(
                "Enter your choice from: \n 1 - Aggregate: Display the Name & Average marks of the student \n 2 - MinMark: Display the minimum marks of the student \n 3 - MaxMark: Display the maximum marks of the student \n 4 - Grade: Display final grade based on Average marks of the student"
            );

            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice >= 1 && choice <= 4)
            {
                Console.WriteLine("You choose: " + choice);
            }

            decimal am;
            string ch;
            switch (choice)
            {
                case (int)Options.Aggregate:

                    // calls set accessor of the property Sname, and get the value of the standard field 'value' from user
                    Console.Write("Student name: ");
                    student.Sname = Console.ReadLine();
                    // Displaying values of the variables
                    Console.WriteLine("Name of the student is: " + student.Sname);

                    am = student.CalculateAverageMarks();
                    Console.WriteLine("The average marks is: " + am);
                    Console.Write("Want to continue? \n Press y or Y for YES, N or n for NO");
                    ch = Console.ReadLine();
                    if (ch == "y" || ch == "Y")
                    {
                        goto Menu;
                    }
                    else
                    {
                        break;
                    }

                case (int)Options.MinMark:

                    Console.Write("Student name: ");
                    student.Sname = Console.ReadLine();
                    am = student.CalculateAverageMarks();
                    decimal lowest = student.minMarks();
                    Console.WriteLine("The Minimum marks is: " + lowest);

                    Console.Write("Want to continue? \n Press y or Y for YES, N or n for NO");
                    ch = Console.ReadLine();
                    if (ch == "y" || ch == "Y")
                    {
                        goto Menu;
                    }
                    else
                    {
                        break;
                    }

                case (int)Options.MaximumMark:

                    Console.Write("Student name: ");
                    student.Sname = Console.ReadLine();
                    am = student.CalculateAverageMarks();
                    decimal highest = student.maxMarks();
                    Console.WriteLine("The Maximum marks is: " + highest);

                    Console.Write("Want to continue? \n Press y or Y for YES, N or n for NO");
                    ch = Console.ReadLine();
                    if (ch == "y" || ch == "Y")
                    {
                        goto Menu;
                    }
                    else
                    {
                        break;
                    }

                case (int)Options.Grade:

                    Console.Write("Student name: ");
                    student.Sname = Console.ReadLine();
                    am = student.CalculateAverageMarks();
                    string result = student.CalculateGrade(am);
                    Console.WriteLine(result);

                    Console.Write("Want to continue? \n Press y or Y for YES, N or n for NO");
                    ch = Console.ReadLine();
                    if (ch == "y" || ch == "Y")
                    {
                        goto Menu;
                    }
                    else
                    {
                        break;
                    }

                default:
                    Console.WriteLine("Wrong option chosen, please choose between 1 to 4");

                    Console.Write("Want to continue? \n Press y or Y for YES, N or n for NO");
                    ch = Console.ReadLine();
                    if (ch == "y" || ch == "Y")
                    {
                        goto Menu;
                    }
                    else
                    {
                        break;
                    }
            }
        }
    }
}
