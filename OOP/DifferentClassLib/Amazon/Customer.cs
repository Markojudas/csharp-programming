namespace Amazon
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var calulator = new RateCalculator();
            System.Console.WriteLine(calulator.Calculate());

        }
    }
}
