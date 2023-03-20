namespace Dimentional_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declares a 1D Array of string.
            string[] weekDays;

            // allocating memory for days.
            weekDays = new string[] {"Sun", "Mon", "Tue", "Wed",
                                       "Thu", "Fri", "Sat"};

            // Displaying Elements of array
            foreach (string day in weekDays)
                Console.Write(day + " ");

            Console.WriteLine("");

            /* Two - Dimensional array with 5 rows and 2 columns*/
            int[,] a = new int[5, 2] { { 0, 0 }, { 1, 2 }, { 2, 4 }, { 3, 6 }, { 4, 8 } };
            int i, j;

            /* output each array element's value */
            for (i = 0; i < 5; i++)
            {

                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("a[{0},{1}] = {2}", i, j, a[i, j]);
                }
            }
            Console.ReadKey();


            // Two-dimensional array
            int[,] intarray = new int[,] { { 1, 2 },
                                         { 3, 4 },
                                         { 5, 6 },
                                         { 7, 8 } };

            // The same array with specified 4 row and 2 column dimensions
            int[,] intarray_d = new int[4, 2] { { 1, 2 }, { 3, 4 },
                                             { 5, 6 }, { 7, 8 } };

            // A similar array with string elements.
            string[,] str = new string[4, 2] { { "one", "two" },
                                            { "three", "four" },
                                            { "five", "six" },
                                            { "seven", "eight" } };

            // Accessing array elements.
            Console.WriteLine("2DArray[0][0] : " + intarray[0, 0]);
            Console.WriteLine("2DArray[0][1] : " + intarray[0, 1]);
            Console.WriteLine("2DArray[1][1] : " + intarray[1, 1]);
            Console.WriteLine("2DArray[2][0] " + intarray[2, 0]);

            Console.WriteLine("2DArray[1][1] (other) : "
                                     + intarray_d[1, 1]);

            Console.WriteLine("2DArray[1][0] (other)"
                                 + intarray_d[1, 0]);

            // using nested loop show string elements
            Console.WriteLine("To String element");
            for (int x = 0; x < 4; x++)
                for (int y = 0; y < 2; y++)
                    Console.Write(str[x, y] + " ");


            // Three-dimensional array.
            int[,,] intarray3D = new int[,,] { { { 1, 2, 3 },
                                             { 4, 5, 6 } },
                                             { { 7, 8, 9 },
                                           { 10, 11, 12 } } };


            // The same array with specified 2, 2 and 3 dimensions
            int[,,] intarray3Dd = new int[2, 2, 3] { { { 1, 2, 3 },
                                                  { 4, 5, 6 } },
                                                  { { 7, 8, 9 },
                                                { 10, 11, 12 } } };

            Console.WriteLine("3DArray[1][0][1] : "
                           + intarray3D[1, 0, 1]);

            Console.WriteLine("3DArray[1][1][2] : "
                              + intarray3D[1, 1, 2]);

            Console.WriteLine("3DArray[0][1][1] (other): "
                                 + intarray3Dd[0, 1, 1]);

            Console.WriteLine("3DArray[1][0][2] (other): "
                                 + intarray3Dd[1, 0, 2]);
        }
    }
}