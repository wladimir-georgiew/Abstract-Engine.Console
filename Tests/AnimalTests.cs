using AnimalsDI.Animals;
using AnimalsDI.Animals.Abstraction;
using AnimalsDI.Constants;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class AnimalTests
    {
        [TestMethod]
        [DataRow(nameof(Cat))]
        [DataRow(nameof(Dog))]
        [DataRow(nameof(Bunny))]
        public void AnimalImplementationsShouldReturnCorrectSpeakMessage(string animalType)
        {
            // Arrange
            var animal = Helpers.GetInstance<Animal?>(
                $"AnimalsDI.Animals.{animalType}",
                "AnimalName_MSTest");

            if (animal == null)
            {
                Assert.Fail($"Requested type - {animalType} does not exist or does not inherit the abstract class {nameof(Animal)}.");
            }
            
            var expectedMessage = string.Format(AnimalSpeechConstants.BaseAnimalSpeech, animal.Name, animal.Sound);

            // Act
            var resultMessage = animal.Speak();

            // Assert
            Assert.AreEqual(expectedMessage, resultMessage);
        }
    }
}