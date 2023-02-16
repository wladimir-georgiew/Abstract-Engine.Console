Simple demo of Dependency Injection, Abstraction and Open-Closed principle for C# with added tests. The code is developed in such way that provides:
- loose coupling between the Engine and the Animal:
- - in Program.cs you can easily switch the injected animal type, without the need to modify Engine.cs
- - the ability to modify/extend the Engine class, without depending on the concrete animal type
- the ability to add new animals, by simply implementing the Animal abstract class and adding new DataRow in the tests (this part can be skipped by loading all classes that implement Animal.cs, instead of using DataRow for each animal)
