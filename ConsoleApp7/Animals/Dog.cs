using AnimalsDI.Animals.Abstraction;

namespace AnimalsDI.Animals;

public class Dog : Animal
{
    public Dog(string name) : base(name)
    {
    }

    public override string Sound => "Woooof!";
}