using AnimalsDI.Animals.Abstraction;

namespace AnimalsDI;

public class Engine
    {
        private readonly Animal _animal;

        public Engine(Animal animal)
        {
            _animal = animal;
        }

        public void Run()
        {
            Console.WriteLine(_animal.Speak());
        }
    }
