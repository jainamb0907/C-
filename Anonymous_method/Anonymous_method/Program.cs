namespace Anonymous_method
{
    internal class Program
    {
        public delegate void petanim(string pet);
        public delegate void Print(int value);
        public delegate void Show(string x);

        public static void PrintHelperMethod(Print printDel, int val)
        {
            val += 10;
            printDel(val);
        }

        // identity method with two parameters
        public static void identity(Show mypet, string color)
        {
            color = " Black" + color;
            mypet(color);
        }

        static void Main(string[] args)
        {
            // An anonymous method with one parameter
            petanim p1 = delegate(string mypet)
            {
                Console.WriteLine("My favorite pet is: {0}", mypet);
            };
            p1("Dog");

            string fav = "Rabbit";
            // Anonymous method with one parameter
            petanim p2 = delegate(string mypet)
            {
                Console.WriteLine("My favorite pet is {0}.", mypet);

                // Accessing variable defined outside the anonymous function
                Console.WriteLine("And I like {0} also.", fav);
            };
            p2("Dog");

            Print prnt1 = delegate(int val)
            {
                Console.WriteLine("Inside Anonymous method. Value: {0}", val);
            };
            prnt1(100);

            int i = 10;
            Print prnt2 = delegate(int val)
            {
                val += i; // Anonymous methods can access variables defined in an outer function
                Console.WriteLine("Anonymous method: {0}", val);
            };
            prnt2(100);

            PrintHelperMethod(
                delegate(int val)
                {
                    Console.WriteLine("Anonymous method passed as Parameter: {0}", val);
                },
                100
            ); //Anonymous Method passed as Parameter

            // Here anonymous method pass as a parameter in identity method
            identity(
                delegate(string color)
                {
                    Console.WriteLine("The color" + " of my dog is {0}", color);
                },
                "White"
            );

            /*
            saveButton.Click += delegate(Object o, EventArgs e) //Anonymous Method as Event Handler
            {
                System.Windows.Forms.MessageBox.Show("Save Successfully!");
            };


            // anonymous method use as a event handler
            MyButton.Click += delegate (Object obj, EventArgs ev)
            {
                System.Windows.Forms.MessageBox.Show("Complete without error...!!");
            }
            */
        }
    }
}
