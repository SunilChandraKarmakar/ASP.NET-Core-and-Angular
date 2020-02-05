using System;
using System.Collections.Generic;
using AnimalSimulatorApp.Model;

namespace AnimalSimulatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal aAnimal = new Tiger();  //Up Casting
            string message = aAnimal.Speek();

            Tiger aTiger = (Tiger)aAnimal; //Down Casting
            string messageTwo = aTiger.Eat();


            List<Animal> animalList = new List<Animal>();      //Up Casting
            animalList.Add(aTiger);
            animalList.Add(new Elephent());
            animalList.Add(new Duck());
            animalList.Add(new Egal());

            foreach (Animal aAnimals in animalList)
            {
                Console.WriteLine(aAnimals.Speek());
            }

            Console.WriteLine("\n\n");

            Console.WriteLine(messageTwo);
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
