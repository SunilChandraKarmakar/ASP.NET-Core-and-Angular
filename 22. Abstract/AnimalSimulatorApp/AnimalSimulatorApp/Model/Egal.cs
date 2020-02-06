using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalSimulatorApp.Model
{
    public class Egal : Animal
    {
        public override string Move()
        {
            return "Move Egal";
        }

        public override string Speek()     //method overriding - Polymorphism
        {
            return "Egal!";
        }
    }
}
