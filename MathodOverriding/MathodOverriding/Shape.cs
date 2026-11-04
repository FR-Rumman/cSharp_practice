using System;
using System.Collections.Generic;
using System.Text;

namespace MathodOverriding

{
    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("draw a Triangle");

        }
    }
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Position { get; set; }
        public int Type { get; set; }

        public virtual void Draw()
        {

        }
    }
}
