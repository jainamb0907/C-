namespace generic_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(1, "One"); //adding key-value using the Add() method
            numberNames.Add(3, "Three");
            numberNames.Add(2, "Two");

            foreach (KeyValuePair<int, string> kvp in numberNames)
                Console.WriteLine("numberNames." + "Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            // Creating another dictionary using Dictionary<TKey,TValue> class
            // adding key/value pairs without using Add method
            Dictionary<string, string> My_dict2 = new Dictionary<string, string>()
            {
                { "a.1", "Dog" },
                { "a.2", "Cat" },
                { "a.3", "Pig" }
            };

            foreach (KeyValuePair<string, string> kvp in My_dict2)
                Console.WriteLine("My_dict2." + "Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            //creating a dictionary using collection-initializer syntax
            var cities = new Dictionary<string, string>()
            {
                { "UK", "London, Manchester, Birmingham" },
                { "USA", "Chicago, New York, Washington" },
                { "India", "Mumbai, New Delhi, Pune" }
            };

            foreach (var kvp in cities)
                Console.WriteLine("cities." + "Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            Console.WriteLine("value of UK key: " + cities["UK"]); //prints value of UK key
            Console.WriteLine("value of USA key: " + cities["USA"]); //prints value of USA key
            //Console.WriteLine(cities["France"]); // run-time exception: Key does not exist

            //use ContainsKey() to check for an unknown key
            if (cities.ContainsKey("France"))
            {
                Console.WriteLine(cities["France"]);
            }

            //use TryGetValue() to get a value of unknown key
            string result;

            if (cities.TryGetValue("France", out result))
            {
                Console.WriteLine(result);
            }

            cities["UK"] = "Liverpool, Bristol"; // update value of UK key
            cities["USA"] = "Los Angeles, Boston"; // update value of USA key

            if (cities.ContainsKey("France")) //check the specified key is present or not
            {
                cities["France"] = "Paris";
            }
            //cities["France"] = "Paris"; //throws run-time exception: KeyNotFoundException

            Console.WriteLine("---access elements using for loop---");
            //use ElementAt() to retrieve key-value pair using index
            for (int i = 0; i < cities.Count; i++)
            {
                Console.WriteLine(
                    "cities." + "Key: {0}, Value: {1}",
                    cities.ElementAt(i).Key,
                    cities.ElementAt(i).Value // cities[cities.ElementAt(i).Key]
                );
            }

            Console.WriteLine("Total Elements present in the cities: {0}", cities.Count);

            cities.Remove("UK"); // removes UK

            if (cities.ContainsKey("France"))
            { // check key before removing it
                cities.Remove("France");
            }

            if (numberNames.ContainsKey(1122) == true)
            {
                Console.WriteLine("Key is found...!!");
            }
            else
            {
                Console.WriteLine("Key is not found...!!");
            }

            /* check the specified value is present or not
            if (numberNames.ContainsValue("GeeksforGeeks") == true)
            {
                Console.WriteLine("Value is found...!!");
            }

            else
            {
                Console.WriteLine("Value is not found...!!");
            }
            */

            Console.WriteLine("Total Elements present in the cities: {0}", cities.Count);

            cities.Clear(); //deletes all elements

            Console.WriteLine("Total Elements after Clear() present in cities: {0}", cities.Count);
        }
    }
}
