namespace extra
{
    //class Person
    //{
    //    public void Introduction(int age = 0, string name)
    //    {
    //        Console.WriteLine("My name is " + name);
    //    }

    //    public void Introduction(string name, int age = 0)
    //    {
    //        Console.WriteLine($"My name is {name} and age is {age}");
    //    }
    //}

    class Program
    {
        public static void Main()
        {
            //Action x = null;
            //x += () => Console.WriteLine("First");
            //x += () =>
            //{
            //    throw new Exception("Bang 1");
            //};
            //x += () =>
            //{
            //    throw new Exception("Bang 2");
            //};
            //x += () => Console.WriteLine("Second");

            //try
            //{
            //    ExecuteAll<Action>(x, action => action());
            //}
            //catch (AggregateException e)
            //{
            //    Console.WriteLine(e);
            //}

            //int[] arr = { 1, 2, 3, 4, 5 };
            //try
            //{
            //    Console.Write(arr[10]);
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine("Index error occurred!");
            //}
            //catch (NullReferenceException ex)
            //{
            //    Console.WriteLine("Null error occurred!");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error occurred!");
            //}

            //Person p = new Person();
            //p.Introduction("Steve");

            //DataProcessor<int> vp = new DataProcessor<int>();
            //vp.Process(90);
            //vp.Process<double>(3.5D);

            //Processor<int> p1 = new DataProcessor<int>();
            //p1.Process(100);
            //DataProcessor<string> p2 = new DataProcessor<string>();
            //p2.Process("TEST");
        }

        //public static void ExecuteAll<T>(Delegate multi, Action<T> invoker)
        //{
        //    List<Exception> exceptions = new List<Exception>();
        //    foreach (var single in multi.GetInvocationList())
        //    {
        //        try
        //        {
        //            invoker((T)(object)single);
        //        }
        //        catch (Exception e)
        //        {
        //            exceptions.Add(e);
        //        }
        //    }
        //    if (exceptions.Count > 0)
        //    {
        //        throw new AggregateException(exceptions);
        //    }
        //}

        //class DataProcessor<T>
        //{
        //    public void Process(T value)
        //    {
        //        Console.Write(value.GetType().Name + "");
        //    }
        //}

        //class Processor<T>
        //{
        //    public void Process(T value)
        //    {
        //        Console.Write(value.GetType().Name + "");
        //    }
        //}

        //class DataProcessor<U> : Processor<U>
        //{

        //}
    }
}
