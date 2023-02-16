using AbstractEngine.Animals.Abstraction;

namespace AbstractEngine.Animals;

public class Cow : IAnimal
{
    public string AnimalType => "Cow";

    public string Sound => "Moo!";
}
