using AbstractEngine.Animals.Abstraction;

namespace AbstractEngine.Animals;

public class Cat : IAnimal
{
    public string AnimalType => "Cat";

    public string Sound => "Meow!";
}