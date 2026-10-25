using System;
using System.Collections.Generic;
using System.Text;

namespace classPrc
{
    public class Person
    {
        public required string firstName;
        public required string lastName;

        public void displayFullName()
        {
            Console.WriteLine($"Full Name: {firstName} {lastName}");
        }
    }
}
