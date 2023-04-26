namespace pointer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {

                // declare variable
                int n = 10;

                // store variable n address location in pointer variable p
                int* p = &n;
                int* p1, p2; // Valid syntax
                p1 = &n;

                Console.WriteLine("Value of the n: " + n);
                Console.WriteLine("address of the n: " + (long)&n);

                Console.WriteLine("Value of n using pointer: " + *p1);
                Console.WriteLine("Addess of the n using pointer or value stored by the pointer itself: " + (long)p1);
                Console.WriteLine("Addess of the pointer itself: " + (long)&p1);

                Console.WriteLine("Value of n:{0}", n);
                Console.WriteLine("Address of n:{0}", (long)p);
            }
        }
    }
}