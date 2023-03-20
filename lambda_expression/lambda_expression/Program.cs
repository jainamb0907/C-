using System;
using System.Linq;
using System.Collections.Generic;

namespace lambda_expression
{ /* Remaining Anatomy of the Lambda Expression*/
    // User defined class Student
    class Student
    {
        // properties rollNo and name
        public int rollNo { get; set; }

        public string name { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Syntax: (parameterList) => lambda body

            // expression lambda that returns the square of a number
            var square1 = (int num) => num * num;
            // passing input to the expression lambda
            Console.WriteLine("Square of number: " + square1(5));

            // statement lambda that takes two int inputs and returns the sum
            var resultingSum = (int a, int b) =>
            {
                int calculatedSum = a + b;
                return calculatedSum;
            };

            // find the sum of 5 and 6
            Console.WriteLine("Total sum: " + resultingSum(5, 6));

            // using lambda expression with delegate type
            // take an int input, delegate multiply it with 3 and return the result
            Func<int, int> multiply = num => num * 3;

            // calls multiply() by passing 5 as an input
            Console.WriteLine(multiply(5));

            // delegate using lambda expression
            Func<int, int> square2 = num => num * num;

            // calling square2() delegate
            Console.WriteLine(square2(7));

            // array containing integer values
            int[] numbers1 = { 2, 13, 1, 4, 13, 5 };

            // lambda expression as method parameter returns the total count of 13 in the numbers1 array
            int totalCount = numbers1.Count(x => x == 13); //Count() is a method

            Console.WriteLine("Total number of 13: " + totalCount);

            // List to store numbers
            List<int> numbers2 = new List<int>() { 36, 71, 12, 15, 29, 18, 27, 17, 9, 34 };

            // foreach loop to display the list
            Console.Write("The list : ");
            foreach (var value in numbers2)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine();

            // Using lambda expression to calculate square of each value in the list
            var square3 = numbers2.Select(x => x * x);

            // foreach loop to display squares
            Console.Write("Squares : ");
            foreach (var value in square3)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine();

            // Using Lambda expression to find all numbers in the list divisible by 3
            List<int> divBy3 = numbers2.FindAll(x => (x % 3) == 0);

            // foreach loop to display divBy3
            Console.Write("Numbers Divisible by 3 : ");
            foreach (var value in divBy3)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine();

            // List with each element of type Student
            List<Student> details = new List<Student>()
            {
                new Student { rollNo = 1, name = "Liza" },
                new Student { rollNo = 2, name = "Stewart" },
                new Student { rollNo = 3, name = "Tina" },
                new Student { rollNo = 4, name = "Stefani" },
                new Student { rollNo = 5, name = "Trish" }
            };

            // To sort the details list based on name of student in ascending order
            var newDetails = details.OrderBy(x => x.name);

            foreach (var value in newDetails)
            {
                Console.WriteLine(value.rollNo + " " + value.name);
            }
        }
    }
}
