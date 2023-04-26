using System.Collections;

namespace Arraylist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an ArrayList
            var arlist1 = new ArrayList();

            /*  create the object of ArrayList class using Interfaces
            some methods of ArrayList class will not be applicable like Reverse(), AddRange() etc.
            // using IList Interface
            IList arrlist1 = new ArrayList();

            // using ICollection Interface
            ICollection arrlist2 = new ArrayList();

            // using IEnumerable Interface
            IEnumerable arrlist3 = new ArrayList();
            */

            ArrayList My_array = new ArrayList();
            // Adding elements in the My_array ArrayList This ArrayList contains elements of the same types
            My_array.Add(1);
            My_array.Add(6);
            My_array.Add(40);
            My_array.Add(10);
            My_array.Add(5);
            My_array.Add(3);
            My_array.Add(2);
            My_array.Add(4);

            My_array.Add(10);
            My_array.Add(5);
            My_array.Add(3);
            Console.WriteLine(My_array.Capacity);

            // adding elements using ArrayList.Add() method
            arlist1.Add(1);
            arlist1.Add("Bill");
            arlist1.Add(" ");
            arlist1.Add(true);
            arlist1.Add(4.5f);
            arlist1.Add(null);

            // adding elements using object initializer syntax
            var arlist2 = new ArrayList() { 2, "Steve", true, 4.5, null };
            Console.WriteLine("ArrayList 1 Elements");

            for (int i = 0; i < arlist1.Count; i++)
                Console.WriteLine($"arlist1[{i}] = {arlist1[i]}");

            Console.WriteLine("ArrayList 2 Elements");
            Console.WriteLine("ArrayList 2 Length: " + arlist2.Count);
            for (int i = 0; i < arlist2.Count; i++)
                Console.WriteLine(arlist2[i]);

            // Adding Entire Array/ArrayList into ArrayList
            int[] arr = { 100, 200, 300, 400 };

            Queue myQ = new Queue();
            myQ.Enqueue("Hello");
            myQ.Enqueue("World!");

            arlist1.AddRange(arlist2); //adding arraylist in arraylist
            arlist1.AddRange(arr); //adding array in arraylist
            arlist1.AddRange(myQ); //adding Queue in arraylist

            Console.WriteLine("ArrayList Elements");

            for (int i = 0; i < arlist1.Count; i++)
                Console.WriteLine($"arlist1[{i}] = {arlist1[i]}");

            //Accessing Elements of ArrayList
            //Access individual item using indexer
            int firstElement = (int)arlist1[0]; //returns 1
            string secondElement = (string)arlist1[1]; //returns "Bill"
            //int secondElement = (int) arlist1[1]; //Error: cannot cover string to int
            Console.WriteLine("First element of arlist1: " + firstElement);

            //using var keyword without explicit casting
            var first = arlist1[0]; //returns 1
            var second = arlist1[1]; //returns "Bill"
            //var fifthElement = arlist1[8]; //Error: Index out of range
            Console.WriteLine("Second element of arlist1: " + second);

            //update elements
            arlist1[0] = "Steve";
            arlist1[1] = 100;
            //arlist1[8] = 500; //Error: Index out of range

            Console.WriteLine("ArrayList1 Elements");
            for (int i = 0; i < arlist1.Count; i++)
                Console.WriteLine($"arlist1[{i}] = {arlist1[i]}");

            //Insert Element in ArrayList
            //Syntax: void Insert(int index, Object value)
            arlist1.Insert(1, "Second Item");

            // Iterate ArrayList
            Console.WriteLine("foreach loop");
            foreach (var item in arlist1)
                Console.Write(item + ", ");

            Console.WriteLine("");
            // Insert Collection in ArrayList
            //Syntax: Void InsertRange(int index, ICollection c)
            arlist1.InsertRange(2, arlist2);

            // Remove Elements from ArrayList
            arlist1.Remove(null); //Removes first occurance of null
            arlist1.RemoveAt(4); //Removes element at specified index
            arlist1.RemoveRange(0, 2); //Removes two elements starting from 1st item (0 index)
            /*arlist1.Clear(); //remove all the elements from the ArrayList
            Console.WriteLine("After Clear() method the " + "number of elements present in the arlist1: " + arlist1.Count); */


            // Check for Elements
            Console.WriteLine(arlist1.Contains(300));
            Console.WriteLine(arlist1.Contains("Bill"));
            Console.WriteLine(arlist1.Contains(10));
            Console.WriteLine(arlist1.Contains("Steve"));

            // To check if the ArrayList Contains element "Steve"
            if (arlist2.Contains("Steve"))
                Console.WriteLine("Yes, exists at index " + arlist2.IndexOf("Steve"));
            else
                Console.WriteLine("No, doesn't exists");

            Console.WriteLine("for loop");
            // ArrayList before sorting
            Console.WriteLine("ArrayList before using Sort() method:");
            for (int i = 0; i < My_array.Count; i++)
                Console.Write(My_array[i] + ", ");

            // Sort the elements of the ArrayList Using sort() method
            My_array.Sort();

            // ArrayList after sorting
            Console.WriteLine("ArrayList after using Sort() method:");
            foreach (var elements in My_array)
            {
                Console.WriteLine($"My_array[{elements}] = {elements}");
            }

            // Displaying count of elements of ArrayList
            Console.WriteLine("Number of elements present in the arlist1: " + arlist1.Count);

            // Displaying Current capacity of ArrayList
            Console.WriteLine("Current capacity of arlist2: " + arlist2.Capacity);

            // -------- IsFixedSize Property --------

            // To check if the ArrayList has fixed size or not
            Console.WriteLine(My_array.IsFixedSize);

            // -------- IsReadOnly Property --------

            // To check if the ArrayList is read-only or not
            Console.WriteLine(My_array.IsReadOnly);
        }
    }
}
