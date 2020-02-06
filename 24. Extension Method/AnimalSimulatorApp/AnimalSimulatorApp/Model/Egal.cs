using AnimalSimulatorApp.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalSimulatorApp.Model
{
    public class Egal : Animal, IFlyable
    {
        public override string Move()
        {
            return "Move Egal";
        }

        public override string Speek()     //method overriding - Polymorphism
        {
            return "Egal!";
        }

        public string Fly()
        {
            return "Egal can fly!";
        }
    }
}
