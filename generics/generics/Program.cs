using System.Reflection;

namespace generics
{
    // user defined Generic classes
    class DataStore<T>
    {
        //Generic Array
        private T[] _data = new T[10];

        public void AddOrUpdate(int index, T item)
        {
            if (index >= 0 && index < 10)
                _data[index] = item;
        }

        //Generic Method Overloading
        /*public void AddOrUpdate(T data1, T data2) { }
        public void AddOrUpdate<U>(T data1, U data2) { }
        public void AddOrUpdate(T data) { }
        */

        public T GetData(int index)
        {
            if (index >= 0 && index < 10)
                return _data[index];
            else
                return default(T);
        }

        public T Data { get; set; }
    }

    class KeyValuePair<TKey, TValue> //  Generic Class with Multiple Type Parameters
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
    }

    // We use < > to specify Parameter type
    public class GFG<T>
    {
        // private data members
        private T data; //Generic Field cannot be initialized

        // using properties
        public T value
        {
            // using accessors
            get { return this.data; }
            set { this.data = value; }
        }
    }

    public class JD // non-generic class
    {
        // Generics method
        public void Display<TypeOfValue>(string msg, TypeOfValue value)
        {
            Console.WriteLine("{0}:{1}", msg, value);
        }
    }

    class Printer
    {
        public void Print<T>(T data) //Generic Method in Non-generic Class
        {
            Console.WriteLine(data);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            DataStore<string> strStore = new DataStore<string>();
            strStore.Data = "Hello World!";
            //strStorage.Data = 123; // compile-time error
            Console.WriteLine(strStore.Data);

            DataStore<int> intStore = new DataStore<int>();
            intStore.Data = 100;
            //intStorage.Data = "Hello World!"; // compile-time error
            Console.WriteLine(intStore.Data);

            KeyValuePair<int, string> kvp1 = new KeyValuePair<int, string>();
            kvp1.Key = 100;
            kvp1.Value = "Hundred";
            Console.WriteLine(kvp1.Key + ", " + kvp1.Value);

            KeyValuePair<string, string> kvp2 = new KeyValuePair<string, string>();
            kvp2.Key = "IT";
            kvp2.Value = "Information Technology";
            Console.WriteLine(kvp2.Key + ", " + kvp2.Value);

            // instance of string type
            GFG<string> name = new GFG<string>();
            name.value = "GeeksforGeeks";

            // instance of float type
            GFG<float> version = new GFG<float>();
            version.value = 5.0F;

            // display GeeksforGeeks
            Console.WriteLine(name.value);

            // display 5
            Console.WriteLine(version.value);

            // creating object of class GFG
            JD j = new JD();

            // calling Generics method
            j.Display<int>("Integer", 122);
            j.Display<char>("Character", 'H');
            j.Display<double>("Decimal", 255.67);

            DataStore<string> cities = new DataStore<string>();
            cities.AddOrUpdate(0, "Mumbai");
            cities.AddOrUpdate(1, "Chicago");
            cities.AddOrUpdate(2, "London");

            Console.WriteLine(cities.GetData(100));

            DataStore<int> empIds = new DataStore<int>();
            empIds.AddOrUpdate(0, 50);
            empIds.AddOrUpdate(1, 65);
            empIds.AddOrUpdate(2, 89);

            Console.WriteLine(empIds.GetData(0));

            Printer printer = new Printer();
            printer.Print<int>(100);
            printer.Print(200); // type infer from the specified value
            printer.Print<string>("Hello");
            printer.Print("World!"); // type infer from the specified value
        }
    }
}
