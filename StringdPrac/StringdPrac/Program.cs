
using System;
using System.Collections.Generic;

namespace StringdPrac
{ 

    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1, "Rokib");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

        }
        
    }
}
