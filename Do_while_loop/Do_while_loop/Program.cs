namespace Do_while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            do
            {
                Console.WriteLine("i = {0}", i);
                i++;

            } while (i < 5);

            //Nested do -while Loop
            i = 0;
            do
            {
                Console.WriteLine("i = {0}", i);
                int j = i;

                i++;

                do
                {
                    Console.WriteLine("j = {0}", j);
                    j++;

                } while (j < 2);

            } while (i < 2);
        }
    }
}