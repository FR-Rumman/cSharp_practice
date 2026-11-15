namespace StopWatchExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new StopWatch();
            for(var i =0; i < 2; i++)
            {
                stopwatch.Start();

                Thread.Sleep(1000);

                stopwatch.Stop();

                Console.WriteLine("Duration: " +stopwatch.GetInterval());

                Console.WriteLine("Press Enter to run the Stopwatch One More Time......");
                Console.ReadLine();
            }
        }
    }
}