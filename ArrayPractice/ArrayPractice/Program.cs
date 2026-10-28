namespace ArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //var number = new[] { 1, 2, 4, 3, 8, 7, 6, 5 };
            ////length
            //Console.WriteLine( "length"+number.Length);

            ////IndexOf

            //var index = Array.IndexOf(number, 5);
            //Console.WriteLine("index number of 5"+index);

            ////clear 
            //Array.Clear(number, 0, 2);
            //Console.WriteLine("Clear Effect");
            //foreach (var n in number)
            //    Console.WriteLine(n);
            ////copy

            //int[] another = new int[3];
            //Array.Copy(number, another, 3);

            //Console.WriteLine("another arry is ");
            //foreach (var n in another)
            //    Console.WriteLine(n);

            ////sort
            //Array.Sort(number);
            //Console.WriteLine("sorted Array");
            //foreach (var n in number)
            //    Console.WriteLine(n);

            ////reverse 
            //Array.Reverse(number);
            //Console.WriteLine("reversed Array");
            //foreach (var n in number)
            //    Console.WriteLine(n);

            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6, 7 });

            foreach (var i in numbers)
                Console.WriteLine(i);


            //index of list
            Console.WriteLine("index of 1:" + numbers.IndexOf(1));
            Console.WriteLine("index of last 1 :" + numbers.LastIndexOf(1));

            // count of list 
            Console.WriteLine("count:" + numbers.Count);


           // remove tow same proparties from the list 
           for(var i =0; i<numbers.Count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }
            foreach (var i in numbers)
                Console.WriteLine(i);

            numbers.Clear();
            Console.WriteLine("count: " + numbers.Count);





        }
    }
}