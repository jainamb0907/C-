namespace Exception_handling
{
    //Syntax:
    /*try
    {
        // statements that may cause an exception
    }
    catch (Specific_Exception_type obj)
    {
        // error handling code
    }
    catch (ExceptionName e2)
    {
        // error handling code
    }
    catch (ExceptionName eN)
    {
        // error handling code
        Throw eN
    }
    finally
    {
        // statements to be executed
    }
    */

    // User defined Exception class Child of Exception
    class DivByZero : Exception
    {
        // Constructor
        public DivByZero()
        {
            Console.Write("Exception has occurred : ");
        }
    }

    internal class Program
    {
        int result;

        Program()
        {
            result = 0;
        }

        public void division(int num1, int num2)
        {
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            finally
            {
                Console.WriteLine("Result: {0}", result);
            }
        }

        // Method to perform Division
        public double DivisionOperation(double numerator, double denominator)
        {
            // throw exception when denominator value is 0
            if (denominator == 0)
                throw new DivByZero();

            // Otherwise return the result of the division
            return numerator / denominator;
        }

        static void Main(string[] args)
        {
            int index;
            int value = 100;
            int[] arr2 = new int[10];
            try
            {
                Console.Write("Enter a number: ");
                index = Convert.ToInt32(Console.ReadLine());
                arr2[index] = value;
            }
            catch (FormatException e)
            {
                Console.Write("Bad Format ");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.Write("Index out of bounds ");
            }
            Console.Write("Remaining program ");

            Program d = new Program();
            d.division(25, 0);
            Console.ReadKey();

            int[] arr1 = { 19, 0, 75, 52 };

            try
            {
                // Try to generate an exception
                for (int i = 0; i < arr1.Length; i++)
                {
                    Console.WriteLine(arr1[i] / arr1[i + 1]);
                }
            }
            // Catch block for invalid array access
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("An Exception has occurred : {0}", e.Message);
            }
            // Catch block for attempt to divide by zero
            catch (DivideByZeroException e)
            {
                Console.WriteLine("An Exception has occurred : {0}", e.Message);
            }
            // Catch block for value being out of range
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("An Exception has occurred : {0}", e.Message);
            }
            // Finally block
            // Will execute irrespective of the above catch blocks
            finally
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    Console.Write(" {0}", arr1[i]);
                }
            }

            Program obj = new Program();
            double num = 9,
                den = 0,
                quotient;
            try
            {
                // Code block that may cause an exception
                quotient = obj.DivisionOperation(num, den);
                Console.WriteLine("Quotient = {0}", quotient);
            }
            // Catch block to catch the generic exception
            catch (Exception e)
            {
                // Message property of exception object e
                // will give the specific type of the exception
                Console.Write(e.Message);
            }
        }
    }
}
