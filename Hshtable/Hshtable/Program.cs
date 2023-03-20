using System.Collections;

namespace Hshtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable numberNames = new Hashtable();
            numberNames.Add(1, "One"); //adding a key/value using the Add() method
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");

            //The following throws run-time exception: key already added.
            //numberNames.Add(3, "Three");

            foreach (DictionaryEntry kvp in numberNames)
                Console.WriteLine("numberNames." + "Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            // Create another hashtable Using Hashtable class and adding key/value pairs without using Add method
            Hashtable my_hashtable2 = new Hashtable()
            {
                { 1, "hello" },
                { 2, 234 },
                { 3, 230.45 },
                { 4, null }
            };

            Console.WriteLine("Key and Value pairs from my_hashtable2:");

            foreach (var ele2 in my_hashtable2.Keys)
            {
                //Console.WriteLine("my_hashtable2." + "Key: {0}, Value: {1}", ele2, my_hashtable2[ele2]);
            }

            //creating a dictionary using collection-initializer syntax
            var cities = new Hashtable()
            {
                { "UK", "London, Manchester, Birmingham" },
                { "USA", "Chicago, New York, Washington" },
                { "India", "Mumbai, New Delhi, Pune" }
            };

            foreach (DictionaryEntry kvp in cities)
                Console.WriteLine("cities." + "Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            // key present or not using Contains method
            Console.WriteLine("4 key present in my_hashtable2? " + my_hashtable2.Contains(4));
            Console.WriteLine("12 key present in my_hashtable2? " + my_hashtable2.Contains(12));

            //value present or not using ContainsValue method
            Console.WriteLine("hello present in my_hashtable2? " + my_hashtable2.ContainsValue("hello"));
            Console.WriteLine("null present in my_hashtable2? " + my_hashtable2.ContainsValue(null));

            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(1, "one");
            dict.Add(2, "two");
            dict.Add(3, "three");

            //Add Dictionary in Hashtable
            Hashtable ht = new Hashtable(dict);

            Console.WriteLine("Total elements of ht: {0}", ht.Count);

            string citiesOfUK = (string)cities["UK"]; //cast to string
            string citiesOfUSA = (string)cities["USA"]; //cast to string

            Console.WriteLine("citiesOfUK: " + citiesOfUK);
            Console.WriteLine("citiesOfUSA: " + citiesOfUSA);

            cities["UK"] = "Liverpool, Bristol"; // update value of UK key
            cities["USA"] = "Los Angeles, Boston"; // update value of USA key

            if (!cities.ContainsKey("France"))
            {
                cities["France"] = "Paris";
            }

            cities.Remove("UK"); // removes UK key/value pair
            //cities.Remove("France"); //throws run-time exception: KeyNotFoundException

            Console.WriteLine("---After updating values---");

            foreach (DictionaryEntry de in cities)
                Console.WriteLine("cities." + "key: {0}, Value: {1}", de.Key, de.Value);

            Console.WriteLine("Total Elements present in the cities: {0}", cities.Count);

            if (cities.ContainsKey("France"))
            { // check key before removing it
                cities.Remove("France");
            }

            cities.Clear(); //removes all elements
            Console.WriteLine(
                "Total Elements after Clear() present in the cities: {0}",
                cities.Count
            );
        }
    }
}
