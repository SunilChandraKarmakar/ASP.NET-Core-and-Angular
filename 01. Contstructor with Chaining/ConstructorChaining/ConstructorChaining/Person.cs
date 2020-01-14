using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorChaining
{
    public class Person
    {
        public Person(string fName, string mName, string lName) : this(fName, lName)
        {
            MiddleName = mName;
        }

        public Person(string fName, string lName) : this()
        {
            FirstName = fName;
            LastName = lName;
        }

        public Person()
        {
            LoyalityPoint = 20;
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; } 
        public int LoyalityPoint { get; }
        public string FullName { get => GetFullName(); }

        private string GetFullName()
        {
            return FirstName + " " + MiddleName + " " + LastName + " " + LoyalityPoint;
        }
    }
}
