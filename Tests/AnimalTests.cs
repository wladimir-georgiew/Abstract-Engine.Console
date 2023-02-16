using AbstractEngine.Animals;
using AbstractEngine.Animals.Abstraction;
using AbstractEngine.Constants;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class AnimalTests
    {
        [TestMethod]
        [DataRow(nameof(Cat))]
        [DataRow(nameof(Dog))]
        [DataRow(nameof(Cow))]
        public void AnimalImplementationsShouldReturnCorrectSpeakMessage(string animalType)
        {
            // Arrange
            var animal = Helpers.GetInstance<IAnimal?>(
                $"{nameof(AbstractEngine)}.Animals.{animalType}");

            if (animal == null)
            {
                Assert.Fail($"Requested type - {animalType} does not exist or does not implement {nameof(IAnimal)}.");
            }
            
            var expectedMessage = string.Format(AnimalSpeechConstants.BaseAnimalSpeech, animal.AnimalType, animal.Sound);

            // Act
            var resultMessage = animal.Speak();

            // Assert
            Assert.AreEqual(expectedMessage, resultMessage);
        }
    }
}