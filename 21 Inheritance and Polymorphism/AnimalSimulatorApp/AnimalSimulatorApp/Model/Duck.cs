﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalSimulatorApp.Model
{
    public class Duck : Animal
    {
        public override string Speek()    //method overriding - Polymorphism
        {
            return "Pak Pak!";
        }
    }
}
