using System;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 2;
            int Count = 10;
            float totalPrice = 20.95f;
            string firstName = "Rumman";
            Console.WriteLine(number);
  
            Console.WriteLine(firstName);
          
            Console.WriteLine(totalPrice);

            Console.WriteLine();

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);

        }

    }

}