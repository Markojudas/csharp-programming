namespace Constructors
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber)
        : base(registrationNumber)
        {
            System.Console.WriteLine("Car is being initizalized. {0}", registrationNumber);
        }
    }
}
