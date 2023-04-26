using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Practical8
{
    interface IMin
    {
        decimal minMarks();
    }

    interface IMax
    {
        decimal maxMarks();
    }

    sealed class Student : IMin, IMax
    {
        public decimal[] marks = new decimal[5];
        static decimal AverageMarks;

        public string Sname // property
        { get; set; }

        // calculates the average marks of students
        public decimal CalculateAverageMarks(string[] everyStudentName)
        {
            decimal sum = 0;

            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write("Subject {0}: ", i + 1);
                try
                {
                    marks[i] = Convert.ToDecimal(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("An Exception has occurred : {0}", e.Message);
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("An Exception has occurred : {0}", e.Message);
                }
                sum += marks[i];
            }

            return AverageMarks = sum / marks.Length;
        }

        public decimal minMarks()
        {
            return marks.Min();
        }

        public decimal maxMarks()
        {
            return marks.Max();
        }

        public string CalculateGrade(decimal AverageMarks)
        {
            int mean = (int)(AverageMarks / 10);
            string grade;
            switch (mean)
            {
                case 10:
                case 9:
                    /* Marks between 90-100 */
                    grade = "Your Grade is: A";
                    return grade;
                case 8:
                    /* Marks between 80-89 */
                    grade = "Your Grade is: B";
                    return grade;
                case 7:
                    /* Marks between 70-79 */
                    grade = "Your Grade is: C";
                    return grade;
                case 6:
                    /* Marks between 60-69 */
                    grade = "Your Grade is: D";
                    return grade;
                default:
                    /* Marks less than 60 */
                    grade = "You Grade is: F or Fail";
                    return grade;
            }
        }
    }
}
