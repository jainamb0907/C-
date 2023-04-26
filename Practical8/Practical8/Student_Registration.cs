using System;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Practical8
{
    abstract class Student_Registration
    {
        public abstract string[] SR();
    }

    class StudentDetails : Student_Registration
    {
        int number;

        public override string[] SR()
        {
            Console.Write("How many students are there? ");
            number = Convert.ToInt32(Console.ReadLine());

            string[] total_Student = new string[number];
            long[] mobile_Number = new long[number];
            string[] email_Address = new string[number];
            string[] blood_Group = new string[number];
            Console.WriteLine("Total number of students are: " + total_Student.Length);
            for (int i = 0; i < total_Student.Length; i++)
            {
                Console.WriteLine();
                Console.Write("----{0} Enter Student name: ", i + 1);
                total_Student[i] = Console.ReadLine();
                Console.WriteLine("----{0} allocated Enrollment Id: {1}", total_Student[i], i + 1);

                try
                {
                    Console.WriteLine();
                    Console.Write("Enter your mobile number: ");
                    mobile_Number[i] = long.Parse(Console.ReadLine());

                    //void Quantity_txt_KeyPress(object sender, KeyPressEventArgs e)
                    //{
                    //    char ch = e.KeyChar;
                    //    if (!Char.IsDigit(ch) && ch != 8)
                    //    {
                    //        e.Handled = true;
                    //    }
                    //}
                }
                catch (FormatException e)
                {
                    Console.WriteLine("An Exception has occurred : {0}", e.Message);
                }

                catch (OverflowException e)
                {
                    Console.WriteLine("An Exception has occurred : {0}", e.Message);
                }
                //finally
                //{
                //    Console.WriteLine("Enter only integer value");
                //}
                Console.WriteLine();
                Console.Write("Enter your Email address: ");
                email_Address[i] = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Enter your Blood group: ");
                blood_Group[i] = Console.ReadLine();
            }

            return total_Student;
        }

        public int ReturnValues()
        {
            return number;
        }
    }
}
