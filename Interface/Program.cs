using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProgram
{
    public interface IAnimal
    {
        void Speak();
    }

    public class Dog : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Woof");
        }
    }

    public class Cat : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Meow");
        }
    }

    public class AnimalCare
    {
        public void MakeAnimalSpeak(IAnimal animal)
        {
            animal.Speak();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AnimalCare animalCare = new AnimalCare();

            Dog dog = new Dog();
            Cat cat = new Cat();

            animalCare.MakeAnimalSpeak(dog);
            animalCare.MakeAnimalSpeak(cat);

            Console.ReadKey();
        }

    }
}
