using System;

namespace AccessModifiers_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1985,4,11),"Jose", "Markojudas");
            System.Console.WriteLine(person.Name + " aka " + person.Username + " is " + person.Age + " years old");

            var laNovia = new Person(new DateTime(1979,3,5), "Damarys", "Demitrius");
            System.Console.WriteLine(laNovia.Name + " aka " + laNovia.Username + " is " + laNovia.Age + " years old");

            System.Console.WriteLine("\nThey are " + (laNovia.Age - person.Age) + " years apart");
        }
    }
}
