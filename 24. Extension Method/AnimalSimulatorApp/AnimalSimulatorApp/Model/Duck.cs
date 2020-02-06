using AnimalSimulatorApp.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalSimulatorApp.Model
{
    public class Duck : Animal, IFlyable
    {  
        public override string Speek()    //method overriding - Polymorphism
        {
            return "Pak Pak!";
        }

        public override string Move()
        {
            return "Move Duck";
        }

        public string Fly()
        {
            return "Duck can fly!";
        }
    }
}
