namespace While_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Exit from the while Loop
            int i = 0;
            while (true)
            {
                Console.WriteLine("i = {0}", i);
                i++;

                if (i > 10)
                    break;
            }

            // Infinite While Loop
            i = 1;
            while (i > 0)
            {
                Console.WriteLine("i = {0}", i);
                i++;
            }

            // Nested while Loop
            i = 0;
            int j = 1;

            while (i < 2)
            {
                Console.WriteLine("i = {0}", i);
                i++;

                while (j < 2)
                {
                    Console.WriteLine("j = {0}", j);
                    j++;
                }
            }
        }
    }
}
