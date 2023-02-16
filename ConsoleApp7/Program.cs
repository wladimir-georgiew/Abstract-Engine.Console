using AnimalsDI.Animals;

namespace AnimalsDI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DC
            var engine = new Engine(new Bunny("Kermit"));
            engine.Run();
        }
    }
}