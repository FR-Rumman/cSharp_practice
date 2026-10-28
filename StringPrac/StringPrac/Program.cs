using System;
namespace StirngPrac

{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            ////int numbers;

            var firstName = "John";
            var lastName = "Doe";

            var fullName = firstName + " " + lastName;

            Console.WriteLine(fullName);

            var myfullName = string.Format("My name is {0} {1}", firstName, lastName);
            Console.WriteLine(myfullName);

            var mathod = ShippingMethod.Express;
            Console.WriteLine((int)mathod);

            

            Console.WriteLine((ShippingMethod)2);

            Console.WriteLine(mathod.ToString());   

            var mathodName = "Express";
            //prasin is getting the string and converting it to enum type
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), mathodName);


        }
    }
}