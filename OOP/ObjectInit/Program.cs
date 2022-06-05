using System;

namespace ObjectInit
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person
                            {
                                FirstName = "Jose",
                                LastName = "Hernandez",
                            };

            Console.WriteLine("Hi! name name is " + person.FirstName + " " + person.LastName);

        }
    }
}
