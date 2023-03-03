using System;

namespace Jagged_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*----------2D Array---------------*/
            // Declare the array of two elements:
            int[][] arr = new int[2][];

            // Initialize the elements:
            arr[0] = new int[5] { 1, 3, 5, 7, 9 };
            arr[1] = new int[4] { 2, 4, 6, 8 };
            Console.WriteLine("Length of 2D Jagged array: " + arr.Length);

            // Another way of Declare and Initialize of elements 
            int[][] arr1 = { new int[] { 1, 3, 5, 7, 9 },
                         new int[] { 2, 4, 6, 8 } };

            // Display the array elements:
            for (int e = 0; e < arr.Length; e++)
            {
                System.Console.Write("Element [" + e + "] Array: ");
                for (int f = 0; f < arr[e].Length; f++)
                    Console.Write(arr[e][f] + " ");
                Console.WriteLine();
            }


            /* a jagged array of 5 array of integers*/
            int[][] a = new int[][]{new int[]{0,0},new int[]{1,2},
            new int[]{2,4},new int[]{ 3, 6 }, new int[]{ 4, 8 } };
            int i, j;

            /* output each array element's value */
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("a[{0}][{1}] = {2}", i, j, a[i][j]);
                }
            }
            Console.ReadKey();




            //mix jagged and multidimensional arrays
            int[][,] arr2 = new int[3][,] {new int[, ] {{1, 3}, {5, 7}},
                                    new int[, ] {{0, 2}, {4, 6}, {8, 10}},
                                    new int[, ] {{11, 22}, {99, 88}, {0, 9}}};

            // Display the array elements:
            for (int q = 0; q < arr2.Length; q++)
            {
                int p = 0;
                for (int r = 0; r < arr2[q].GetLength(p); r++)
                {
                    for (int k = 0; k < arr2[r].Rank; k++)
                        Console.Write(" arr2[" + q + "][" + r + ", " + k + "]:"
                                                       + arr2[q][r, k] + " ");
                    Console.WriteLine();
                }
                p++;
                Console.WriteLine();
            }
        }
    }
}