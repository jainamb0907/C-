using System.Drawing;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray2 = new int[5] { 1, 2, 3, 4, 5 };
            int[] intArray3 = { 1, 2, 3, 4, 5 };
            //We may also omit the size of the array
            int[] marks = new int[] { 99, 98, 92, 97, 95 };
            int[] score = marks;

            // declares an Array of integers.
            int[] intArray1;

            // allocating memory for 5 integers.
            intArray1 = new int[5];

            // initialize the first elements of the array
            intArray1[0] = 10;

            // initialize the second elements of the array
            intArray1[1] = 20;

            // so on...
            intArray1[2] = 30;
            intArray1[3] = 40;
            intArray1[4] = 50;

            // accessing the elements using for loop
            Console.Write("For loop :");
            for (int i = 0; i < intArray1.Length; i++)
                Console.Write(" " + intArray1[i]);

            Console.WriteLine("");
            Console.Write("For-each loop :");

            // using for-each loop
            foreach (int i in intArray1)
                Console.Write(" " + i);

            Console.WriteLine("");
            Console.Write("while loop :");

            // using while loop
            int j = 0;
            while (j < intArray1.Length)
            {
                Console.Write(" " + intArray1[j]);
                j++;
            }

            Console.WriteLine("");
            Console.Write("Do-while loop :");

            // using do-while loop
            int k = 0;
            do
            {
                Console.Write(" " + intArray1[k]);
                k++;
            } while (k < intArray1.Length);
        }
    }
}
