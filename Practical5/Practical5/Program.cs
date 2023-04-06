namespace Practical5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray1 = new int[5] { 99, 98, 92, 97, 95 };
            // accessing the elements using for loop
            Console.WriteLine("For loop :");
            for (int i = 0; i < intArray1.Length; i++)
                Console.WriteLine($"intArray1[{i}] = {intArray1[i]}");

            try
            {
                Console.WriteLine(intArray1[5]); // throws IndexOutOfRange exception
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }
            finally
            {
                Console.WriteLine("This is finally block");
            }
        }
    }
}
