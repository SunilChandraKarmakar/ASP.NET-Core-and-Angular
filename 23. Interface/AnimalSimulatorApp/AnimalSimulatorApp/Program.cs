using System;
using System.Collections.Generic;
using AnimalSimulatorApp.Human;
using AnimalSimulatorApp.Interface;
using AnimalSimulatorApp.Model;

namespace AnimalSimulatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IFlyable> flyableObj = new List<IFlyable>();
            flyableObj.Add(new Egal());
            flyableObj.Add(new Duck());
            flyableObj.Add(new SuperHuman.Superman());
            flyableObj.Add(new Transport.Rocket());

            foreach (IFlyable obj in flyableObj)
            {
                Console.WriteLine(obj.Fly());
            }

            Console.WriteLine("\n\n");

            People aPeople = new People();
            
            foreach (Person item in aPeople)
            {
                
            }

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
                Console.WriteLine(aAnimals.Move());
            }

            Console.WriteLine("\n\n");

            Console.WriteLine(messageTwo);
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
