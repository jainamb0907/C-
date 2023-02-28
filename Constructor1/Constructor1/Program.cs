namespace Constructor1
{
        class Car
        {
            public string model; // Create a field
            public string color;
            public int year;

            // Create a class constructor with multiple parameters for the Car class
            public Car(string modelName, string modelColor, int modelYear)
            {
                model = modelName; // Set the initial value for model
                color = modelColor;
                year = modelYear;
            }

            static void Main(string[] args)
            {
                // Create an object of the Car Class (this will call the constructor)
                Car Ford = new Car("Mustang", "Red", 1969);
                Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);
            }
        }
}