using System;

namespace LamdaExpressionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, string, string> fullName = (fName, lName) =>
            {
                return fName + " " + lName;
            };

            string name = fullName("Sunil", "Karmakar");
            Console.WriteLine(name);

            Action<string> addNumber = (message) => 
            {
                int a = 10, b = 20;
                int r = a + b;
                Console.WriteLine(message + r);
            };

            addNumber("Add: ");
            Console.ReadKey();
        }
    }
}
