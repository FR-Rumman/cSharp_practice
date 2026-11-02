using System;
using System.Collections.Generic;
using System.Text;

namespace StringdPrac
{
    public class Customer
    {
        public int Id;
        public String Name;
        public List<Order> Orders;

        public Customer()
        {

            Orders = new List<Order>();
        }
        public Customer(int id)
            :this()
        {
            this.Id = id;

        }
        public Customer(int id, string name)
            :this(id)
        {
           
            this.Name = name;

        }

    }
}
