namespace Generic_Hashset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating HashSet Using HashSet class
            HashSet<string> myhash1 = new HashSet<string>();

            // Add the elements in HashSet Using Add method
            myhash1.Add("C");
            myhash1.Add("C++");
            myhash1.Add("C#");
            myhash1.Add("Java");
            myhash1.Add("Ruby");
            Console.WriteLine("Elements of myhash1:");

            // Accessing elements of HashSet Using foreach loop
            int i = 0;
            foreach (var val in myhash1)
            {
                Console.WriteLine($"myhash1[{i}] = {val}");
                i++;
            }
            Console.WriteLine("");

            // Creating another HashSet using collection initializer to initialize HashSet
            HashSet<int> myhash2 = new HashSet<int>() { 10, 100, 1000, 10000, 100000 };

            // Display elements of myhash2
            Console.WriteLine("Elements of myhash2:");
            i = 0;
            foreach (var value in myhash2)
            {
                Console.WriteLine($"myhash2[{i}] = {value}");
                i++;
            }
            Console.WriteLine("");

            // Creating HashSet using HashSet class and HashSet<T>() Constructor
            var myhash3 = new HashSet<string>();
            // myhash3 = myhash1;

            myhash3.Add("PHP");
            myhash3.Add("Python");
            myhash3.Add("C++");
            myhash3.Add("Perl");
            myhash3.Add("Java");

            Console.WriteLine("Elements of myhash3:");
            i = 0;
            foreach (var val in myhash3)
            {
                Console.WriteLine($"myhash3[{i}] = {val}");
                i++;
            }
            Console.WriteLine("");

            // Using UnionWith method
            myhash1.UnionWith(myhash3);
            Console.WriteLine("Elements of myhash1 after performing Union:");
            i = 0;
            foreach (var val in myhash1)
            {
                Console.WriteLine($"myhash1[{i}] = {val}");
                i++;
            }
            Console.WriteLine(
                "Total number of elements present" + " in myhash1:{0}",
                myhash1.Count
            );
            Console.WriteLine("");

            // Using IntersectWith method
            myhash1.IntersectWith(myhash3);
            Console.WriteLine("Elements of myhash1 after performing IntersectWith:");
            i = 0;
            foreach (var val in myhash1)
            {
                Console.WriteLine($"myhash1[{i}] = {val}");
                i++;
            }
            Console.WriteLine(
                "Total number of elements present" + " in myhash1:{0}",
                myhash1.Count
            );
            Console.WriteLine("");

            // Using ExceptWith method
            myhash1.ExceptWith(myhash3);
            Console.WriteLine("Elements of myhash1 after performing ExceptWith:");
            i = 0;
            foreach (var val in myhash1)
            {
                Console.WriteLine($"myhash1[{i}] = {val}");
                i++;
            }
            Console.WriteLine(
                "Total number of elements present" + " in myhash1:{0}",
                myhash1.Count
            );
            Console.WriteLine("");

            // Before using Remove method
            Console.WriteLine(
                "Total number of elements present (Before Removal)" + " in myhash3: {0}",
                myhash3.Count
            );

            // Using Remove method
            myhash3.Remove("Perl");

            // After using Remove method
            Console.WriteLine(
                "Total number of elements present (After Removal)" + " in myhash3: {0}",
                myhash3.Count
            );
            Console.WriteLine("");

            Console.WriteLine("Elements of myhash3:");
            i = 0;
            foreach (var val in myhash3)
            {
                Console.WriteLine($"myhash3[{i}] = {val}");
                i++;
            }
            Console.WriteLine("");

            // Remove all elements from HashSet Using Clear method
            myhash3.Clear();
            Console.WriteLine(
                "Total number of elements present" + " in myhash3:{0}",
                myhash3.Count
            );
        }
    }
}
