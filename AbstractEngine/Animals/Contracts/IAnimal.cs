using AbstractEngine.Constants;

namespace AbstractEngine.Animals.Abstraction;

public interface IAnimal
{
    public abstract string AnimalType { get; }

    public abstract string Sound { get; }

    public string Speak()
    {
        return string.Format(AnimalSpeechConstants.BaseAnimalSpeech, AnimalType, Sound);
    }
}
