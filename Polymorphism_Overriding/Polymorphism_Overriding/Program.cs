namespace Polymorphism_Overriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();  // Create a Animal object
            //Pig myPig = new Pig();  // Create a Pig object
            //Dog myDog = new Dog();  // Create a Dog object

            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();

        }
    }
}