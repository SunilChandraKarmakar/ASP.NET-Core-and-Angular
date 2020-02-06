using AnimalSimulatorApp.Interface;
using AnimalSimulatorApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalSimulatorApp.SuperHuman
{
    public class Superman : Animal, IFlyable
    {
        public override string Move()
        {
            return "Supernam can move.";
        }

        public string Fly()
        {
            return "Superman can fly!";
        }
    }
}
