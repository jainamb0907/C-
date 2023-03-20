namespace Practical1_2__DebuggingApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userResponse = Console.ReadLine();
            // int.Parse(userResponse); // Convert string to int32

            if (Convert.ToBoolean(int.Parse(userResponse)))
            {
                Console.WriteLine("The entered value is a integer");
            }
        }
    }
}
