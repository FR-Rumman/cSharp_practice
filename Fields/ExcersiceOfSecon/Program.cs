namespace ExcersiceOfSecon
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int SecretNumber = random.Next(1, 11);
            Console.WriteLine("select a secrete Number fro 1 to 10 (**)");
            bool iscorrect = false;
            for(int i = 1; i<5; i++)
            {
                Console.WriteLine("Guess the Number chance {0}:",i);
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess == SecretNumber)
                {
                    iscorrect = true;
                    break;

                }
            }
            if (iscorrect)
            {
                Console.WriteLine("you won the game gussing number is {0}", SecretNumber);
            }
            else
            {
                Console.WriteLine("you lost the secrate number is {0}", SecretNumber);
            }

        }
    }
}