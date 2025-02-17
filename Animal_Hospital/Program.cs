namespace Animal_Hospital
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Skapar 11 Djur
            List<Animal> animals = new List<Animal>
            {
                new Animal("Dog", "Buddy", 5, 4, true, Colour.Brown),
                new Animal("Cat", "Whiskers", 3, 4, true, Colour.White),
                new Animal("Parrot", "Polly", 2, 2, false, Colour.Patterned),
                new Animal("Rabbit", "Fluffy", 1, 4, true, Colour.White),
                new Animal("Horse", "Shadow", 10, 4, false, Colour.Black),
                new Animal("Dog", "Bella", 8, 4, true, Colour.Brown),
                new Animal("Chicken", "Clucky", 2, 2, true, Colour.White),
                new Animal("Goat", "Billy", 4, 4, false, Colour.Patterned),
                new Animal("Pig", "Oinky", 6, 4, true, Colour.Brown),
                new Animal("Fish", "Goldie", 1, 0, false, Colour.Patterned),
                new Animal("Turtle", "Shelly", 50, 4, false, Colour.Patterned)
            };

            // 1. Hur många hundar?

            var numberOfDogs = animals.Count(a => a.Species == "Dog");

            Console.WriteLine($"Total number of dogs: {numberOfDogs}");
            Console.WriteLine("=======================================================================");

            // 2. Äldsta djuret

            var oldestAnimal = animals.OrderByDescending(a => a.Age).First();

            Console.WriteLine($"Oldest animal:");
            oldestAnimal.DisplayInfo();

            Console.WriteLine("=======================================================================");

            // 3. Ny lista med bara vaccinerade djur

            var vaccinatedAnimals = animals.Where(a => a.Vaccinated == true).ToList();

            Console.WriteLine($"Vaccinated animals:");
            vaccinatedAnimals.ForEach(a =>
            {
                a.DisplayInfo();

                if (a != vaccinatedAnimals.Last())
                {
                    Console.WriteLine("----------------------");
                }
            });

            Console.WriteLine("=======================================================================");

            // 4. Ny lista med 4-benta djur äldre än 3 år

            var filteredAnimalList = animals.Where(a => a.NumberOfLegs == 4 && a.Age > 3).ToList();

            Console.WriteLine($"Four legged animals older than 3 years old:");
            foreach (var animal in filteredAnimalList)
            {
                animal.DisplayInfo();

                if (animal != filteredAnimalList.Last())
                {
                    Console.WriteLine("----------------------");
                }
            }

            Console.WriteLine("=======================================================================");

            // 5. Finns det ett djur som heter Shadow?
            var isAnimalNamedShadow = animals.Any(a => a.Name == "Shadow");

            if (!isAnimalNamedShadow)
                Console.WriteLine("There are no animals named Shadow");

            else
                Console.WriteLine("There is an animal named Shadow!");

        }
    }
}
