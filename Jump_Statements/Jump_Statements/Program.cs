namespace Jump_Statements
{
    internal class Program
    {
        static int Addition(int a)
        {

            // add two value and return the result of addition 
            int add = a + a;

            // using return statement
            return add;
        }

        // taking null in the string
        static string sub = null;

        // method to display subject name   
        static void displaysubject(string sub1)
        {
            if (sub1 == null)
                throw new NullReferenceException("Exception Message");

        }

        static void Main(string[] args)
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
                if (i == 4)
                {
                    break;
                }
            }

            for (i = 1; i < 4; i++)
            {
                if (i == 3)
                    break;

                Console.WriteLine("GeeksforGeeks");
            }


            while (i < 10)
            {
                if (i == 4)
                {
                    i++;
                    continue;
                }
                Console.WriteLine(i);
                i++;
            }

            for (i = 1; i <= 10; i++)
            {

                // if the value of i becomes 4 then it will skip 4 and send the transfer to the for loop and continue with 5
                if (i == 4)
                    continue;

                Console.WriteLine(i);
            }

            int number = 20;
            switch (number)
            {

                case 5:
                    Console.WriteLine("case 5");
                    break;
                case 10:
                    Console.WriteLine("case 10");
                    break;
                case 20:
                    Console.WriteLine("case 20");
                    // goto statement transfer the control to case 5
                    goto case 5;

                default:
                    Console.WriteLine("No match found");
                    break;

            }

            number = 2;
            // calling addition function
            int result = Addition(number);
            Console.WriteLine("The addition is {0}", result);


            // using try catch block to handle the Exception
            try
            {

                // calling the static method
                displaysubject(sub);
            }

            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
    }
}