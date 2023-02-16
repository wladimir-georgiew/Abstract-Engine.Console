using AbstractEngine.Animals.Abstraction;

namespace AbstractEngine.Animals;

public class Dog : IAnimal
{
    public string AnimalType => "Dog";

    public string Sound => "Woof!";
}