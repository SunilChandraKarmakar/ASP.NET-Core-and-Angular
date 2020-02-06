using AnimalSimulatorApp.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalSimulatorApp.Transport
{
    public class Rocket : IFlyable
    {
        public string Fly()
        {
            return "Rocket can fly!";
        }
    }
}
