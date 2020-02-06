using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalSimulatorApp.Model
{
    public abstract class Animal
    {
        public virtual string Speek()
        {
            return "I can Speek!";
        }

        public string Eat()
        {
            return "I can Eat!";
        }

        public abstract string Move();
    }
}
