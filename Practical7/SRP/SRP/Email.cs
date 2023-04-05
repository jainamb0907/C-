namespace SRP
{
    internal class Email
    {
        public static bool SendEmail(string emailContent)
        {
            Console.WriteLine($"Email message: {emailContent}");
            return true;
        }
    }
}
