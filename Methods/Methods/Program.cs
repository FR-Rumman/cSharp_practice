namespace Methods
{
    class Program
    {
        public static void Main(string[] args)
        {
            var point = new Point(10, 20);
            point.Move(new Point(50, 60));
            Console.WriteLine("point is at {0}, {1}", point.X, point.Y);

            point.Move(100, 200);
            Console.WriteLine("point is at {0}, {1}", point.X, point.Y);



        }
    }
}