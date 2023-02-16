using AnimalsDI.Constants;

namespace AnimalsDI.Animals.Abstraction;

public abstract class Animal
{
    protected Animal(string name)
    {
        Name = name;
    }
    public string Name { get; set; }

    public abstract string Sound { get; }

    public string Speak()
    {
        return string.Format(AnimalSpeechConstants.BaseAnimalSpeech, Name, Sound);
    }
}