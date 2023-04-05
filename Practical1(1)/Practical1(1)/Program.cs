namespace Practical1_1_
{

    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter first number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your choice:\n 1- Addition\n 2- Substraction\n 3- Division\n 4- Multiplication\n 5- Modulous");
            Console.Write("You choose: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int ans = 0;
            switch (x)
            {
                case 1:

                    ans = n1 + n2;
                    Console.WriteLine("The Sum of the first and second number is: " + ans);
                    break;
                case 2:
                    ans = n1 - n2;
                    Console.WriteLine("The Substraction of the first and second number is: " + ans);
                    break;
                case 3:
                    ans = n1 / n2;
                    Console.WriteLine("The Division of the first and second number is: " + ans);
                    break;
                case 4:
                    ans = n1 * n2;
                    Console.WriteLine("The Multiplication of the first and second number is: " + ans);
                    break;
                case 5:
                    ans = n1 % n2;
                    Console.WriteLine("The Modulo of the first and second number is: " + ans);
                    break;
            }
        }
    }

}