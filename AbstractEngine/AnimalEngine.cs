using AbstractEngine.Animals.Abstraction;
using AbstractEngine.Contracts;

namespace AbstractEngine;

public class AnimalEngine : IEngine
{
    private readonly IAnimal _animal;

    public AnimalEngine(IAnimal animal)
    {
        _animal = animal;
    }

    public void Run()
    {
        Console.WriteLine(_animal.Speak());
    }
}
