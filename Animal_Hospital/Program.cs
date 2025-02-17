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

            

        }
    }
}
