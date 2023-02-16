using AnimalsDI.Animals.Abstraction;

namespace AnimalsDI.Animals;

public class Cat : Animal
{
    public Cat(string name) : base(name)
    {
    }

    public override string Sound => "Meowww!";
}