using extension_method;

namespace extension_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;

            bool result = i.IsGreaterThan(100);

            Console.WriteLine("Result: {0}", result);
        }
    }
}