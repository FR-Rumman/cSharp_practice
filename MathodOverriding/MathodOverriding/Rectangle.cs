using System;
using System.Collections.Generic;
using System.Text;

namespace MathodOverriding
{
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("draw a rectangle");

        }
    }
}
