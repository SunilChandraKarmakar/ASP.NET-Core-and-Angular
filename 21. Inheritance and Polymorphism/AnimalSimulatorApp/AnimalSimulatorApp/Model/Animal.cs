using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalSimulatorApp.Model
{
    public class Animal
    {
        public virtual string Speek()
        {
            return "I can Speek!";
        }

        public virtual string Eat()
        {
            return "I can Eat!";
        }

        public virtual string Move()
        {
            return "I can Move!";
        }
    }
}
