namespace keywords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(int.MaxValue);

            checked
            {
                int val = int.MaxValue;
                Console.WriteLine(val + 2);
            }

            int a = 2147483647;
            int b = 2147483647;
            int c = a + b; //give us unexpected or garbage result
            c = checked(a + b); //throw runtime exception
            Console.WriteLine(c);


            const int x = 2147483647;
            const int y = 2147483647;
            // int z = x + y; //unchecked keyword works almost the same way as the default compiler works
            int z = unchecked(x + y);
            Console.WriteLine(z);

            unchecked
            {
                int val = int.MaxValue;
                Console.WriteLine(val + 2);
            }
            Console.ReadLine();
        }
    }
}