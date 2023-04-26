using System.Collections;

namespace Generic__stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();
            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);
            numbers.Push(4);

            int i = 0;
            foreach (var item in numbers)
            {
                Console.WriteLine($"numbers[{i}] = {item}");
                i++;
            }
            Console.WriteLine();

            Stack my_stack2 = new Stack();

            // Adding elements in the Stack Using Push method
            my_stack2.Push("Geeks");
            my_stack2.Push("geeksforgeeks");
            my_stack2.Push('G');
            my_stack2.Push(null);
            my_stack2.Push(1234);
            my_stack2.Push(490.98);

            foreach (var itm in my_stack2)
            {
                Console.WriteLine($"my_stack2[{i}] = {itm}");
                i++;
            }

            // Obtain the topmost element of my_stack Using Pop method
            Console.WriteLine("Topmost element of my_stack2" + " is: {0}", my_stack2.Pop());

            // Obtain the topmost element of my_stack Using Peek method
            Console.WriteLine("Topmost element of my_stack2 " + "is: {0}", my_stack2.Peek());

            // Checking if the element is present in the Stack or not
            if (my_stack2.Contains("GeeksforGeeks") == true)
            {
                Console.WriteLine("Element is found...!!");
            }

            else
            {
                Console.WriteLine("Element is not found...!!");
            }

            Console.WriteLine("Total elements present " + "in my_stack2: {0}", my_stack2.Count);

            //Create and Add Elements in Stack
            int[] arr = new int[] { 1, 2, 3, 4 };
            Stack<int> myStack1 = new Stack<int>(arr);

            foreach (var itm in myStack1)
            {
                Console.WriteLine($"myStack1[{i}] = {itm}");
                i++;
            }

            Console.WriteLine("Number of elements in Stack: {0}", myStack1.Count);

            if (myStack1.Count > 0)
            {
                //Retrieve Elements usign Peek()
                Console.WriteLine(myStack1.Peek());
                Console.WriteLine(myStack1.Peek());
            }

            Console.WriteLine("Number of elements in Stack: {0}", myStack1.Count);
            Console.WriteLine(myStack1.Contains(2));
            Console.WriteLine(myStack1.Contains(10));

            Console.WriteLine("Number of elements in Stack: {0}", myStack1.Count);

            while (myStack1.Count > 0)
                Console.Write(myStack1.Pop() + ",");

            Console.WriteLine();
            Console.WriteLine("Number of elements in Stack: {0}", myStack1.Count);
        }
    }
}
