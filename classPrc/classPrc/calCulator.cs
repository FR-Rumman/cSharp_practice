//using System;
//using System.Collections.Generic;
//using System.Reflection.Metadata.Ecma335;
//using System.Text;
//using System.Threading.Channels;

namespace classPrc
{
    public class CalCulator
    {
        public int result;

        public CalCulator(int a, int b)
        {
            result = a + b;
            Console.WriteLine($"The sum of {a} and {b} is: {result}");
        }
    }
}
