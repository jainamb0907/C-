namespace Structure
{
    // first structure defined with public modifier
    public struct Address
    {
        // data member of Address structure
        public string City;
        public string State;
    }


    // Another structure
    struct Person
    {
        // data member of Person structure
        public string Name;
        public int Age;
        public int Weight;

        // Nesting of Address structure by creating A1 of type Address
        public Address A1;
    }

    struct Books
    {
        private string title;
        private string author;
        private string subject;
        private int book_id;

        public void getValues(string t, string a, string s, int id)
        {
            title = t;
            author = a;
            subject = s;
            book_id = id;
        }

        public void display()
        {
            Console.WriteLine("Title : {0}", title);
            Console.WriteLine("Author : {0}", author);
            Console.WriteLine("Subject : {0}", subject);
            Console.WriteLine("Book_id :{0}", book_id);
        }
    };


    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare P1 of type Person
            Person P1;

            // P1's data
            P1.Name = "Keshav Gupta";
            P1.Age = 21;
            P1.Weight = 80;

            /*
            // Declare P2 of type Person
            Person P2;

            // Copying the values of P1 into P2
            P2 = P1;

            // Displaying the values of P2
            Console.WriteLine("Values Stored in P2");
            Console.WriteLine("Name: " + P2.Name);
            Console.WriteLine("Age: " + P2.Age);
            Console.WriteLine("Weight: " + P2.Weight);
            */


            // Displaying the values of P1
            Console.WriteLine("Values Stored in P1");
            Console.WriteLine("Name: " + P1.Name);
            Console.WriteLine("Age: " + P1.Age);
            Console.WriteLine("Weight: " + P1.Weight);
            Console.WriteLine("");

            // Assigning values to the nested structure data members
            P1.A1.City = "ABC_City";
            P1.A1.State = "XYZ_State";
            Console.WriteLine("City: " + P1.A1.City);
            Console.WriteLine("State: " + P1.A1.State);



            Books Book1 = new Books();   /* Declare Book1 of type Book */
            Books Book2 = new Books();   /* Declare Book2 of type Book */

            /* book 1 specification */
            Book1.getValues("C Programming",
            "Nuha Ali", "C Programming Tutorial", 6495407);

            /* book 2 specification */
            Book2.getValues("Telecom Billing",
            "Zara Ali", "Telecom Billing Tutorial", 6495700);

            /* print Book1 info */
            Book1.display();

            /* print Book2 info */
            Book2.display();

            Console.ReadKey();
        }
    }
}