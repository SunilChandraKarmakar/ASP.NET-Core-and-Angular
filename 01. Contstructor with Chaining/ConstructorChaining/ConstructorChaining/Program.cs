using System;

namespace ConstructorChaining
{
    class Program
    {
        static void Main(string[] args)
        {
            Person personOne = new Person("Sunil", "Karmakar");
            string fullName = personOne.FullName;

            Person personTwo = new Person("Sunil", "Chandra", "Karmakar");
            string fullNameTwo = personTwo.FullName;

            Person personThree = new Person();

            Console.WriteLine("Full Name : " + fullNameTwo);
            Console.ReadKey();
        }
    }
}
