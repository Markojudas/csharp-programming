using System.Collections.Generic;

namespace Constructors
{
    public class Customer
    {
        public string Name;
        public int Id;
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }

        //overload ^
        public Customer(int id): this()
        {
            this.Id = id;
        }

        //overload!^
        public Customer(int id, string name) : this(id)
        {
            this.Name = name;
        }

    }
}

