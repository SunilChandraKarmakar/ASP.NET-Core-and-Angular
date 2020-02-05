using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalSimulatorApp.Model
{
    public class Elephent : Animal
    {
        public override string Speek()     //method overriding - Polymorphism
        {
            return "Elephent";
        }

        public override string Move()
        {
            return "Move Elephent";
        }
    }
}
