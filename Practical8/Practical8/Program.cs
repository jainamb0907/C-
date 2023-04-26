using System.Diagnostics;
using System.Reflection.Emit;
using System.ComponentModel.Design;

namespace Practical8
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

        public static void Display(string[] everyStudentName, decimal[] everyStudentMeanMarks)
        {
            Console.WriteLine();
            for (int i = 0; i < everyStudentName.Length; i++)
            {
                Console.WriteLine(
                    "{0} Student Name is: {1} & Average marks is: {2}",
                    i + 1,
                    everyStudentName[i],
                    everyStudentMeanMarks[i]
                );
            }
        }

        public static void Display(decimal[] everyStudentMinMarks, string[] everyStudentName)
        {
            for (int i = 0; i < everyStudentName.Length; i++)
            {
                Console.WriteLine(
                    "{0} Student Name is: {1} & Minimum marks is: {2}",
                    i + 1,
                    everyStudentName[i],
                    everyStudentMinMarks[i]
                );
            }
        }

        public static void Display(string[] everyStudentGrades, string[] everyStudentName)
        {
            for (int i = 0; i < everyStudentName.Length; i++)
            {
                Console.WriteLine(
                    "{0} Student Name is: {1} & {2}",
                    i + 1,
                    everyStudentName[i],
                    everyStudentGrades[i]
                );
            }
        }

        static void Main(string[] args)
        {
            Student student = new Student();
            StudentDetails details = new StudentDetails();
            decimal am = 0,
                lowest_Marks = 0,
                highest_Marks = 0;
            string result = "";
            int number;
            string[] total_Student = details.SR();
            number = total_Student.Length;

            //Console.WriteLine("How many students are there?");
            //int number = Convert.ToInt32(Console.ReadLine());

            //string[] total_Student = new string[number];
            int ts = details.ReturnValues();

            decimal[] individual_Average_Marks = new decimal[ts];
            decimal[] individual_Min_Marks = new decimal[ts];
            decimal[] individual_Max_Marks = new decimal[ts];
            string[] individual_Grade = new string[ts];
            //Console.WriteLine("Total number of students are: " + total_Student.Length);
            Console.WriteLine();
            Console.WriteLine("----Each student need to enter marks here subjectvise----");
            for (int i = 0; i < total_Student.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine("{0} Student name {1}", i + 1, total_Student[i]);

                am = student.CalculateAverageMarks(total_Student);
                individual_Average_Marks[i] = am;
                lowest_Marks = student.minMarks();
                individual_Min_Marks[i] = lowest_Marks;
                highest_Marks = student.maxMarks();
                individual_Max_Marks[i] = highest_Marks;
                result = student.CalculateGrade(am);
                individual_Grade[i] = result;
            }

            Menu:
            Console.WriteLine();
            Console.WriteLine("-----Menu for the User-----");
            Console.WriteLine(
                "Enter your choice from: "
                    + "\n 1 - Aggregate: Display the Name & Average marks of the student "
                    + "\n 2 - MinMark: Display the minimum marks of the student "
                    + "\n 3 - MaxMark: Display the maximum marks of the student "
                    + "\n 4 - Grade: Display final grade based on Average marks of the student"
            );

            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice >= 1 && choice <= 4)
            {
                Console.WriteLine("You choose: " + choice);
            }

            string ch;
            switch (choice)
            {
                case (int)Options.Aggregate:

                    // Displaying values of the variables
                    Display(total_Student, individual_Average_Marks);
                    Console.WriteLine();
                    Console.WriteLine("Do you want to Continue? press Y for Yes and N for No");
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

                    Display(individual_Min_Marks, total_Student);
                    Console.WriteLine();
                    Console.WriteLine("Do you want to Continue? press Y for Yes and N for No");
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

                    for (int i = 0; i < total_Student.Length; i++)
                    {
                        Console.WriteLine(
                            "{0} Student Name is: {1} & Maximum marks is: {2}",
                            i + 1,
                            total_Student[i],
                            individual_Max_Marks[i]
                        );
                    }
                    Console.WriteLine();
                    Console.WriteLine("Do you want to Continue? press Y for Yes and N for No");
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

                    Display(individual_Grade, total_Student);
                    Console.WriteLine();
                    Console.WriteLine("Do you want to Continue? press Y for Yes and N for No");
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

                    Console.WriteLine();
                    Console.WriteLine("Wrong option chosen, please choose between 1 to 4");
                    Console.WriteLine();
                    Console.WriteLine("Do you want to Continue? press Y for Yes and N for No");
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
