using System;
using System.Collections.Generic;
using System.Text;

namespace MathodOverriding
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("draw a circle");

        }
    }
}
