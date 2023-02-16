using AnimalsDI.Animals.Abstraction;

namespace AnimalsDI.Animals;

public class Bunny : Animal
{
    public Bunny(string name) : base(name)
    {
    }

    public override string Sound => "Hop!";
}
