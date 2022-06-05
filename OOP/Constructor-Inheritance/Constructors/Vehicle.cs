namespace Constructors
{
    public class Vehicle
    {
        private readonly string registrationNumber;

        // public Vehicle()
        // {
        //     System.Console.WriteLine("Vehicle is being Initialized");
        // }

        public Vehicle(string registrationNumber)
        {
            this.registrationNumber = registrationNumber;
            System.Console.WriteLine("Vehcile is being initialized {0}", registrationNumber);
        }
    }
}
