using System.Linq.Expressions;

namespace else_if_statments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10,
                j = 20;

            if (i != j)
            {
                if (i < j)
                {
                    Console.WriteLine("i is less than j");
                }
                else if (i > j)
                {
                    Console.WriteLine("i is greater than j");
                }
            }
            else
                Console.WriteLine("i is equal to j");

            //Ternary Operator(?:)
            //variable_name = (condition) ? TrueExpression : FalseExpression;
            int x = 10,
                y = 100;
            var result = x > y ? "x is greater than y" : "x is less than y"; // a ternary operator is short form of if else statement
            Console.WriteLine(result);

            //Nested Ternary Operator
            result =
                x > y
                    ? "x is greater than y"
                    : x < y
                        ? "x is less than y"
                        : x == y
                            ? "x is equal to y"
                            : "No result";
            Console.WriteLine(result);

            x = 5;
            y = 10;
            int z = 15;
            var answer =
                x * 3 > y
                    ? x
                    : y > z
                        ? y
                        : z; //The ternary operator is right-associative
            Console.WriteLine(answer);
        }
    }
}


/*if (condition1)
{
    if (condition2)
    {
        // code block to be executed when condition1 and condition2 evaluates to true
    }
    else if (condition3)
    {
        if (condition4)
        {
            // code block to be executed when only condition1, condition3, and condition4 evaluates to true
        }
        else if (condition5)
        {
            // code block to be executed when only condition1, condition3, and condition5 evaluates to true
        }
        else
        {
            // code block to be executed when
            //      condition1, and condition3 evaluates to true
            //      condition4 and condition5 evaluates to false
        }
    }
}

else
   // code block to be executed when above all conditions are false

*/
