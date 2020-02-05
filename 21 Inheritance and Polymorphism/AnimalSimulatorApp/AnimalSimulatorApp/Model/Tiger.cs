using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalSimulatorApp.Model
{
    public class Tiger : Animal
    {
        public override string Speek()     //method overriding - Polymorphism
        {
            return "Halum Halum!";
        }
    }
}
