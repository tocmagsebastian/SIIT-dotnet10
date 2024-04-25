namespace Handout
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person();
            person1.Name = "John";
            person1.Age = "20";

            Console.WriteLine($"{person1.Name} - {person1.Age}");

            Person mary = new Person("Mary", "18");

            Console.WriteLine($"{mary.Name} - {mary.Age}");

            Person nick = new Person("Nick", "43");

            Console.WriteLine($"{nick.Name} - {nick.Age}");

        }

    }
}