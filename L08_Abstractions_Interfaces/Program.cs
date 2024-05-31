using L08_Abstractions_Interfaces.Creatures;
using L08_Abstractions_Interfaces.Shapes;

namespace L08_Abstractions_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // BREAKOUT ROOM 1
            var myFavoriteCreatures = new List<FairytaleCreature>()
            {
                new Princess(),
                new Witch(),
                new Knight()
            };

            foreach (var creature in myFavoriteCreatures)
            {
                Console.WriteLine($"I am a {creature.GetType().Name}");
                creature.WriteMyHobbies();
                Console.WriteLine();
            }

            // BREAKOUT ROOM 2
            var myShapes = new List<Shape>()
            {
                new Circle(5.3),
                new Circle(25),
                new Rectangle(5, 4),
                new Rectangle(7.3, 13.8)
            };

            foreach (var shape in myShapes)
            {
                Console.WriteLine(Math.Round(shape.CalculateArea(), 2));
                Console.WriteLine(Math.Round(shape.CalculatePerimeter(), 2));
                Console.WriteLine();
            }
        }
    }
}
