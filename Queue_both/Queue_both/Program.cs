using System.Collections;

namespace Queue_both
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> callerIds = new Queue<int>();
            callerIds.Enqueue(1);
            callerIds.Enqueue(2);
            callerIds.Enqueue(3);
            callerIds.Enqueue(4);

            int i = 0;
            foreach (var id in callerIds)
            {
                Console.WriteLine($"numbers[{i}] = {id}");
                i++;
            }
            Console.WriteLine();

            Queue my_queue = new Queue();

            // Adding elements in Queue Using Enqueue() method
            my_queue.Enqueue("GFG");
            my_queue.Enqueue(1);
            my_queue.Enqueue(100);
            my_queue.Enqueue(null);
            my_queue.Enqueue(2.4);
            my_queue.Enqueue("Geeks123");

            i = 0;
            foreach (var el in my_queue)
            {
                Console.WriteLine($"my_queue[{i}] = {el}");
                i++;
            }
            Console.WriteLine();

            Queue<string> strQ = new Queue<string>();
            strQ.Enqueue("H");
            strQ.Enqueue("e");
            strQ.Enqueue("l");
            strQ.Enqueue("l");
            strQ.Enqueue("o");

            Console.WriteLine("Total elements present in my_queue: {0}", my_queue.Count);
            my_queue.Dequeue();

            // After Dequeue method
            Console.WriteLine("Total elements present in my_queue: {0}", my_queue.Count);

            // Remove all the elements from the queue
            my_queue.Clear();

            // After Clear method
            Console.WriteLine("Total elements present in my_queue: {0}", my_queue.Count);

            Console.WriteLine("Total elements: {0}", strQ.Count); //prints 5

            if (strQ.Count > 0)
            {
                Console.WriteLine(strQ.Peek()); //prints H
                Console.WriteLine(strQ.Peek()); //prints H
                Console.WriteLine(strQ.Peek()); //prints H
            }

            // Contains() Signature: bool Contains(object obj);
            Console.WriteLine(callerIds.Contains(2)); //true
            Console.WriteLine(callerIds.Contains(10)); //false

            while (strQ.Count > 0)
                Console.WriteLine(strQ.Dequeue()); //prints Hello

            Console.WriteLine("Total elements: {0}", strQ.Count); //prints 0
        }
    }
}
