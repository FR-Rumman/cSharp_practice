using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        
        public void Move(Point newLocation)
        {
            ArgumentNullException.ThrowIfNull(newLocation);
            int x = newLocation.X;
            X = x;
            this.Y = newLocation.Y;
        }
    }
}
