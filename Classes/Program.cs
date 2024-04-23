namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog(); // default ctor initialization 

            dog.Name = "Lucky";
            dog.Breed = "Boxer";

            Console.WriteLine(dog.Name);

            Dog beagle = new Dog("Spot", "Beagle"); // inline initialization
            beagle.Name = "Bella";
            Console.WriteLine($"{beagle.Name} - {beagle.Breed}");
        }

    }


}
