using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalSimulatorApp.Calculation
{
    public static class ExtensionClaculator
    {
        public static int Subtract(this Calculator calculator, int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }
    }
}
