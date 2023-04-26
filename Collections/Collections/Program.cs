using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* generic collection using List<T> */
            // Creating a List of integers
            List<int> mylist = new List<int>();

            // adding items in mylist
            for (int j = 5; j < 10; j++)
            {
                mylist.Add(j * 3);
            }

            // Displaying items of mylist by using foreach loop
            foreach (int items in mylist)
            {
                Console.WriteLine(items);
            }

            /* non-generic collection using Queue */
            // Creating a Queue
            Queue myQueue = new Queue();

            // Inserting the elements into the Queue
            myQueue.Enqueue("C#");
            myQueue.Enqueue("PHP");
            myQueue.Enqueue("Perl");
            myQueue.Enqueue("Java");
            myQueue.Enqueue("C");

            // Displaying the count of elements contained in the Queue
            Console.Write("Total number of elements present in the Queue are: ");

            Console.WriteLine(myQueue.Count);

            // Displaying the beginning element of Queue
            Console.WriteLine("Beginning Item is: " + myQueue.Peek());

            // Creating a collection of ints
            Collection<int> myColl = new Collection<int>();

            // Adding elements in Collection myColl
            myColl.Add(2);
            myColl.Add(3);
            myColl.Add(4);
            myColl.Add(5);

            // Displaying the elements in myColl
            foreach (int i in myColl)
            {
                Console.WriteLine(i);
            }

            // Creating a collection of strings
            Collection<string> myColls = new Collection<string>();

            // Adding elements in Collection myColl
            myColls.Add("A");
            myColls.Add("B");
            myColls.Add("C");
            myColls.Add("D");
            myColls.Add("E");

            // ------- Count Property ----------

            // To print the count of elements in Collection
            Console.WriteLine("String collection Count : " + myColls.Count);

            // -------- Item[Int32] Property --------

            // Get the element at index 2
            Console.WriteLine("Element at index 2 is : " + myColls[2]);

            // Get the element at index 3
            Console.WriteLine("Element at index 3 is : " + myColls[3]);

            // Checking if an element is in the Collection
            // The function returns "True" if the item is present in Collection else returns "False"
            Console.WriteLine(myColls.Contains("A"));

            // Creating a string array
            string[] myArr = new string[myColls.Count];

            // Copying the entire Collection to a compatible one-dimensional Array, starting at the specified index of the target array
            myColls.CopyTo(myArr, 0);

            // Displaying the elements in myArr
            foreach (string str in myArr)
            {
                Console.WriteLine(str);
            }
        }
    }
}
