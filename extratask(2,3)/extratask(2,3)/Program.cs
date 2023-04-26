namespace extratask_2_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Find the sizeof the DataTypes
            Console.WriteLine("Size of char: " + sizeof(char));
            Console.WriteLine("Size of Short: " + sizeof(short));
            Console.WriteLine("Size of boolean: " + sizeof(bool));

            Console.WriteLine("Size of int: " + sizeof(int));
            Console.WriteLine("Size of long: " + sizeof(long));

            Console.WriteLine("Size of float: " + sizeof(float));
            Console.WriteLine("Size of double: " + sizeof(double));
            Console.WriteLine("Size of decimal: " + sizeof(decimal));

            // check whether integers are equal or not
            int num1,
                num2;

            Console.WriteLine("Input the values for Number1 and Number2 : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Number1 and Number2 are equal\n");
            }
            else
            {
                Console.WriteLine("Number1 and Number2 are not equal\n");
            }

            Console.ReadKey();
        }
    }
}
