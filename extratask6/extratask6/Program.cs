//print all unique element in an array
using System.Drawing;

namespace extratask6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[7];
            int i,
                j,
                k,
                size;
            Console.WriteLine("Enter size of the array: ");
            size = int.Parse(Console.ReadLine());
            //Reads elements in array
            Console.WriteLine("Enter elements in the array: ");

            for (i = 0; i < size; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            int n = arr.Length;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < i; j++)
                    if (arr[i] == arr[j])
                        break;
                if (i == j)
                    Console.Write(arr[i]+ " ");
            }
            



            //int[] arr = new int[100];
            //int i,
            //    j,
            //    k,
            //    size,
            //    isUnique;

            ////Reads size of the array
            //Console.WriteLine("Enter size of the array: ");
            //size = Convert.ToInt32(Console.ReadLine());

            ////Reads elements in array
            //Console.WriteLine("Enter elements in the array: ");
            //for (i = 0; i < size; i++)
            //{
            //    Console.Write("element - {0} : ", i);
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            ////Removing all duplicate elements from the array
            //for (i = 0; i < size; i++)
            //{
            //    // Assuming  cuurent element is unique
            //    isUnique = 1;

            //    for (j = i + 1; j < size; j++)
            //    {
            //        //If any duplicate element is found
            //        if (arr[i] == arr[j])
            //        {
            //            // Removing duplicate element
            //            for (k = j; k < size - 1; k++)
            //            {
            //                arr[k] = arr[k + 1];
            //            }

            //            size--;
            //            j--;
            //            isUnique = 0;
            //        }
            //    }

            //    /*If array element is not unique then also remove the current element */
            //    if (isUnique != 1)
            //    {
            //        for (j = i; j < size - 1; j++)
            //        {
            //            arr[j] = arr[j + 1];
            //        }

            //        size--;
            //        i--;
            //    }
            //}

            ////Printing all unique elements in array
            //Console.WriteLine("All unique elements in the array are: ");
            //for (i = 0; i < size; i++)
            //{
            //    Console.WriteLine(arr[i] + "\t");
            //}
        }
    }
}
