using System.Xml.Linq;
using System.Collections.Generic;

namespace List_T_
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating list using List class and List<T>() Constructor
            var primeNumbers = new List<int>();
            // adding elements using add() method
            primeNumbers.Add(1);
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);

            List<int> intList = new List<int>() { 23,22,35,90,56,12,55,67,88};
            // Without sorted List
            Console.WriteLine("UnSorted intList:");
            int i = 0;
            intList.ForEach(el => Console.WriteLine($"intList[{i}] = {el}"));
            Console.WriteLine("intList contains 23? " + intList.Contains(23));

            //Insert() signature:void Insert(int index, T item);
            intList.Insert(1, 11); // inserts 11 at 1st index: after 23.

            // After Sort method
            intList.Sort();
            Console.WriteLine("Sorted List:");
            i = 0;
            foreach (var el in intList)
            {
                Console.WriteLine($"intList[{i}] = {el}");
                i++;
            }

            Console.WriteLine("intList contains 10? "+intList.Contains(10));

            //Remove() signature: bool Remove(T item)
            //RemoveAt() signature: void RemoveAt(int index)

            // Initial count
            Console.WriteLine("Initial count:{0}", intList.Count);

            // After using Remove() method
            intList.Remove(88); // removes the first 88 from a list
            Console.WriteLine("2nd count:{0}", intList.Count);

            // After using RemoveAt() method
            intList.RemoveAt(4); //removes the 5th element (index starts from 0)
            //intList.RemoveAt(10); //throws ArgumentOutOfRangeException
            Console.WriteLine("3rd count:{0}", intList.Count);

            // After using RemoveRange() method
            intList.RemoveRange(0, 2);
            Console.WriteLine("4th count:{0}", intList.Count);

            /* After using Clear() method
            intList.Clear();
            Console.WriteLine("5th count:{0}", intList.Count);
            */

            for (i = 0; i < intList.Count; i++)
                Console.WriteLine($"intList[{i}] = {intList[i]}");

            Console.WriteLine("No of elelemts present in primeNumbersList: " + primeNumbers.Count);

            var cities = new List<string>();
            cities.Add("New York");
            cities.Add("London");
            cities.Add("Mumbai");
            cities.Add("Chicago");
            cities.Add(null); // null is allowed

            Console.WriteLine("No of elelemts present in citiesList: " + cities.Count);

            // adding elements using collection initializer syntax
            var bigCities = new List<string>() { "New York", "London", "Mumbai", "Chicago" };

            Console.WriteLine("No of elelemts present in bigCitiesList: " + bigCities.Count);

            var students = new List<Student>()
            {
                // adds objects of the Student class in the List<Student>
                new Student() { Id = 1, Name = "Bill" },
                new Student() { Id = 2, Name = "Steve" },
                new Student() { Id = 3, Name = "Ram" },
                new Student() { Id = 4, Name = "Abdul" }
            };

            //get all students whose name is Bill using LINQ Query
            var studNames = from s in students where s.Name == "Bill" select s;

            foreach (var student in studNames)
                Console.WriteLine(student.Id + ", " + student.Name);

            Console.WriteLine("No of elelemts present in studentsList: " + students.Count);

            // AddRange() signature: void AddRange(IEnumerable<T> collection)
            string[] fcities = new string[3] { "Chicago", "London", "New York" };

            // adding an array in a List
            bigCities.AddRange(fcities);

            // adding a List
            cities.AddRange(bigCities);

            Console.WriteLine("No of elelemts present in bigCitiesList: " + bigCities.Count);
            Console.WriteLine("No of elelemts present in citiesList: " + cities.Count);
        }
    }
}
