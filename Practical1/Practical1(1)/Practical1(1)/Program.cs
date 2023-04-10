namespace Practical1_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(
                "Enter your choice:\n 1- Addition\n 2- Substraction\n 3- Division\n 4- Multiplication\n 5- Modulous"
            );
            Console.Write("You choose: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            int ans;
            switch (choice)
            {
                case 1:

                    ans = firstNumber + secondNumber;
                    Console.WriteLine("The Sum of the first and second number is: " + ans);
                    break;
                case 2:
                    ans = firstNumber - secondNumber;
                    Console.WriteLine("The Substraction of the first and second number is: " + ans);
                    break;
                case 3:
                    ans = firstNumber / secondNumber;
                    Console.WriteLine("The Division of the first and second number is: " + ans);
                    break;
                case 4:
                    ans = firstNumber * secondNumber;
                    Console.WriteLine(
                        "The Multiplication of the first and second number is: " + ans
                    );
                    break;
                case 5:
                    ans = firstNumber % secondNumber;
                    Console.WriteLine("The Modulo of the first and second number is: " + ans);
                    break;
            }
        }
    }
}
