using System;
using Amazon;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            customer.Promote();
        }
    }
}
