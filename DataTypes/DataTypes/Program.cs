namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Value Type */

            Console.WriteLine("Size of int: " + sizeof(int)); //To get the exact storage size of types in bytes

            // declaring character
            char a = 'G';

            // Integer data type is generally used for numeric values
            int i = 89;

            short s = 56;

            // this will give error as number is larger than short range
            // short s1 = 87878787878;

            // long uses Integer values which may signed or unsigned 
            long l = 4564;

            // UInt data type is generally used for unsigned integer values 
            uint ui = 95;

            ushort us = 76;

            // ulong data type is generally used for unsigned integer values
            ulong ul = 3624573;

            // by default fraction value is double in C#
            double d = 8.358674532;

            // for float use 'f' as suffix
            float f = 3.7330645f;

            // for float use 'm' as suffix
            decimal dec = 389.5m;

            Console.WriteLine("char: " + a);
            Console.WriteLine("integer: " + i);
            Console.WriteLine("short: " + s);
            Console.WriteLine("long: " + l);
            Console.WriteLine("float: " + f);
            Console.WriteLine("double: " + d);
            Console.WriteLine("decimal: " + dec);
            Console.WriteLine("Unsinged integer: " + ui);
            Console.WriteLine("Unsinged short: " + us);
            Console.WriteLine("Unsinged long: " + ul);



            sbyte sb = 126;

            // sbyte is 8 bit singned value
            Console.WriteLine(sb);

            sb++;
            Console.WriteLine(sb);

            // It overflows here because byte can hold values from -128 to 127 
            sb++;
            Console.WriteLine(sb);

            // Looping back within the range
            sb++;
            Console.WriteLine(sb);



            byte c = 0;

            // byte is 8 bit unsigned value
            Console.WriteLine(c);

            c++;
            Console.WriteLine(c);

            c = 254;

            // It overflows here because byte can hold values from 0 to 255
            c++;
            Console.WriteLine(c);

            // Looping back within the range
            c++;
            Console.WriteLine(c);



            bool b = true;
            if (b == true)
                Console.WriteLine("Hi Geek");



            /* Reference Type */

            //string and String are equivalent.
            string s1 = "hello"; // creating through string keyword  
            Console.WriteLine(s1);
            String s2 = "welcome"; // creating through String class
            Console.WriteLine(s2);

            // declaring string
            string s3 = "Geeks";

            //append in a
            s3 += "for";
            s3 = s3 + "Geeks";
            Console.WriteLine(s3);


            // declare object obj
            object obj;
            obj = 100; // this is boxing
            Console.WriteLine(obj);

            // to show type of object using GetType()
            Console.WriteLine(obj.GetType());


            dynamic e = 20;
            Console.WriteLine(e);



            unsafe
            {

                // declare variable
                int n = 10;

                // store variable n address location in pointer variable p
                int* p = &n;
                int* p1, p2; // Valid syntax
                p1 = &n;

                Console.WriteLine("Value of the n: " + n);
                Console.WriteLine("address of the n: " + (long)&n);

                Console.WriteLine("Value of n using pointer: " + *p1);
                Console.WriteLine("Addess of the n using pointer or value stored by the pointer itself: " + (long)p1);
                Console.WriteLine("Addess of the pointer itself: " + (long)&p1);

                Console.WriteLine("Value of n:{0}", n);
                Console.WriteLine("Address of n:{0}", (long)p);
            }
        }
    }
}


