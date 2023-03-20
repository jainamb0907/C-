using System;

namespace extratask1
{
    internal class Program
    {
        //Remove Even Integers From an Array
        public static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Element[" + (i) + "]: " + arr[i]);
            }
            Console.WriteLine();
        }

        public static int[] removeEven(int[] arr)
        {
            int oddCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    oddCount++;
                }
            }
            int[] result = new int[oddCount];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    result[index] = arr[i];
                    index++;
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            int[] intArray1 = new int[9]  { 1, 2, 34, 56, 7, 8, 9, 3, 4 };
            Console.WriteLine("Elements before deletion:");
            printArray(intArray1);

            int[] result = removeEven(intArray1);

            //intArray1 = Array.FindAll(intArray1, i => intArray1[i] % 2 != 0).ToArray();
            //Console.WriteLine(String.Join(",", intArray1));

            Console.WriteLine("Elements after deletion: ");
            printArray(result);
        }
    }
}
