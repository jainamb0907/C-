namespace Local_function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables of main method
            int x = 40;
            int y = 60;

            // Local Function
            void AddValue(int a, int b)
            {
                Console.WriteLine("Value of a is: " + a);
                Console.WriteLine("Value of b is: " + b);
                Console.WriteLine("Value of x is: " + x);
                Console.WriteLine("Value of y is: " + y);
                Console.WriteLine("Sum: {0}", a + b + x + y);
                Console.WriteLine();
            }

            // Calling Local function
            AddValue(50, 80);
            AddValue(79, 70);


            // Local Generic Function
            void MyMethod1<MyValue>(MyValue value)
            {
                Console.WriteLine("Value is: " + value);
            }

            // Calling local generic function
            MyMethod1<int>(123);
            MyMethod1<string>("GeeksforGeeks");
            MyMethod1<char>('G');
            MyMethod1<double>(45453.5656);


            // Local Function with out parameter
            void MyMethod2(string str, out string s)
            {
                s = str + "for"
                    + "Geeks";
            }
            string a = null;

            // Calling Local function
            MyMethod2("Geeks", out a);
            Console.WriteLine(a);
            Console.WriteLine("");


            // pass params in local function
            void MyMethod3(params string[] data)
            {
                for (int x = 0; x < data.Length; x++)
                {
                    Console.WriteLine(data[x]);
                }
            }
            // Calling Local function
            MyMethod3("Geeks", "gfg", "GeeksforGeeks", "123geeks");
        }
    }
}