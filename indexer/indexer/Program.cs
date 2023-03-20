namespace indexer
{
    internal class Program
    {
        class StringDataStore
        {
            private string[] strArr = new string[10]; // internal data storage
            public string this[int index]
            {
                get => strArr[index];
                set => strArr[index] = value;
            }
        }

        class IndexerCreation
        {
            // class members
            private string[] val = new string[3];

            // Indexer declaration
            // public - access modifier
            // string - the return type of the Indexer
            // this - is the keyword having a parameters list
            public string this[int index]
            {

                // get Accessor retrieving the values stored in val[] array of strings
                get
                {
                    return val[index];
                }

                // set Accessor setting the value at passed index of val
                set
                {
                    // value keyword is used to define the value being assigned by the set indexer.
                    val[index] = value;
                }
            }
        }
        static void Main(string[] args)
        {
            // creating an object of parent class which acts as primary address for using Indexer
            IndexerCreation ic = new IndexerCreation();

            // Inserting values in ic[]
            // Here we are using the object of class as an array
            ic[0] = "C";
            ic[1] = "CPP";
            ic[2] = "CSHARP";

            Console.Write("Printing values stored in objects used as arrays\n");

            // printing values
            Console.WriteLine("First value = {0}", ic[0]);
            Console.WriteLine("Second value = {0}", ic[1]);
            Console.WriteLine("Third value = {0}", ic[2]);

            StringDataStore strStore = new StringDataStore();

            strStore[0] = "One";
            strStore[1] = "Two";
            strStore[2] = "Three";
            strStore[3] = "Four";

            for (int i = 0; i < 10; i++)
                Console.WriteLine(strStore[i]);
        }
    }
}

/*remaining: https://www.tutorialsteacher.com/csharp/csharp-indexer */
/* Syntax:
         [access_modifier][return_type] this[argument_list]
         {
             get
             {
                 // return the value from the specified index of an internal collection
             }
             set
             {
                 // set values at the specified index in an internal collection
             }

         } */
