namespace extratask4
{
    internal class Program
    {
        // Reverse a Number and Check if it is a Palindrome
        static void Main(string[] args)
        {
            int num,
                temp,
                remainder,
                reverse = 0;
            Console.WriteLine("Enter an integer \n");
            num = int.Parse(Console.ReadLine());
            //temp = num;
            //while (num > 0)
            //{
            //    remainder = num % 10;
            //    reverse = reverse * 10 + remainder;
            //    num /= 10;
            //}

            for (temp = num; num != 0; num = num / 10)
            {
                remainder = num % 10;
                reverse = reverse * 10 + remainder;
            }

            Console.WriteLine("Given number is = {0}", temp);
            Console.WriteLine("Its reverse is  = {0}", reverse);
            if (temp == reverse)
                Console.WriteLine("Number is a palindrome \n");
            else
                Console.WriteLine("Number is not a palindrome \n");
            Console.ReadLine();
        }
    }
}
