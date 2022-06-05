namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();

            customer.Id = 1;
            customer.Name = "Jose";

            var order = new Order();
            customer.Orders.Add(order);

            System.Console.WriteLine(customer.Id);
            System.Console.WriteLine(customer.Name);

            var customer2 = new Customer(
                1398700,
                "Markojudas"
            );

            var customer3 = new Customer(
                id : 666,
                name : "Jose"
            );

            System.Console.WriteLine(customer3.Id);
            System.Console.WriteLine(customer3.Name);

        }
    }
}
