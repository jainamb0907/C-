using System;
using System.IO;  // include the System.IO namespace

namespace Files
{
    class Program
    {
        //C# program to write user input to a file using StreamWriter Class
        class WriteToFile
        {

            public void Data()
            {
                // This will create a file named sample.txt at the specified location              
                StreamWriter sw = new StreamWriter("H://geeksforgeeks.txt");

                // To write on the console screen
                Console.WriteLine("Enter the Text that you want to write on File");

                // To read the input from the user
                string str = Console.ReadLine();

                // To write a line in buffer
                sw.WriteLine(str);

                // To write in output stream
                sw.Flush();

                // To close the stream
                sw.Close();
            }
        }

        // C# program to read from a file using StreamReader Class
        class ReadFile
        {

            public void DataReading()
            {
                // Takinga a new input stream i.e. geeksforgeeks.txt and opens it 
                StreamReader sr = new StreamReader("H://geeksforgeeks.txt");

                Console.WriteLine("Content of the File");

                // This is use to specify from where to start reading input stream
                sr.BaseStream.Seek(0, SeekOrigin.Begin);

                // To read line from input stream
                string str = sr.ReadLine();

                // To read the whole file line by line
                while (str != null)
                {
                    Console.WriteLine(str);
                    str = sr.ReadLine();
                }
                Console.ReadLine();

                // to close the stream
                sr.Close();
            }
        }


        static void Main(string[] args)
        {
            string writeText = "Hello World!";  // Create a text string
            File.WriteAllText("filename.txt", writeText);  // Create a file and write the contents of writeText to it

            string readText = File.ReadAllText("filename.txt"); // Read the contents of the file
            Console.WriteLine(readText); // Output the content


            bool p = File.Exists("filename.txt");
            Console.WriteLine(p);



            FileStream F = new FileStream("test.dat", FileMode.OpenOrCreate,
            FileAccess.ReadWrite);

            for (int i = 1; i <= 20; i++)
            {
                F.WriteByte((byte)i);
            }

            F.Position = 0;
            for (int i = 0; i <= 20; i++)
            {
                Console.Write(F.ReadByte() + " ");
            }
            F.Close();
            Console.ReadKey();



            WriteToFile wr = new WriteToFile();
            wr.Data();
            Console.ReadKey();



            ReadFile rw = new ReadFile();
            rw.DataReading();

        }
    }
}