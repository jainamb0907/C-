namespace Nullable_types
{

    class MyClass
    {
        public Nullable<int> y;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass mycls = new MyClass();

            if (mycls.y == null)
                Console.WriteLine("Null");


            Nullable<int> i = null;

            if (i.HasValue) /*The HasValue returns true if the object has been assigned a value; if it has not been assigned any value or has been assigned a null value, it will return false.*/
                Console.WriteLine(i.Value); // or Console.WriteLine(i)
            else
                Console.WriteLine("Null");


            // defining Nullable type
            Nullable<int> n = null;

            // using the method output will be 0 as default value of null is 0
            Console.WriteLine(n.GetValueOrDefault());

            // defining Nullable type
            int? n1 = null;

            // using the method output will be 0 as default value of null is 0
            Console.WriteLine(n1.GetValueOrDefault());

            int? x = null;
            int j = x ?? 0; /*'??' operator to specify that if i is null then assign 0 to j.*/
            Console.WriteLine(j);


            // using Nullable type syntax to define non-nullable
            int? n2 = 47;

            // using the method
            Console.WriteLine(n2.GetValueOrDefault());

            // using Nullable type syntax to define non-nullable
            Nullable<int> n3 = 457;

            // using the method
            Console.WriteLine(n3.GetValueOrDefault());


            int? i1 = null;
            int j1 = 10;

            if (i1 < j1)
                Console.WriteLine("i < j");
            else if (i1 > 10)
                Console.WriteLine("i > j");
            else if (i1 == 10)
                Console.WriteLine("i == j");
            else
                Console.WriteLine("Could not compare");


            int? i2 = null;
            int j2 = 10;

            if (Nullable.Compare<int>(i2, j2) < 0)
                Console.WriteLine("i < j");
            else if (Nullable.Compare<int>(i2, j2) > 0)
                Console.WriteLine("i > j");
            else
                Console.WriteLine("i = j");


            // a is nullable type and contains null value
            int? a = null;

            // b is nullable type int and behave as a normal int
            int? b = 2345;

            // this will not print anything on console
            Console.WriteLine(a);

            // gives 2345 as output
            Console.WriteLine(b);
        }
    }
}