using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthDate(new DateTime(1985,4,11));
            System.Console.WriteLine(person.GetBirthDate());
        }
    }
}
