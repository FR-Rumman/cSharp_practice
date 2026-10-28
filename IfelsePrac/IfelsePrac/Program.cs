using System.Security.Cryptography.X509Certificates;

namespace IfelsePrac
{
    class Program
    {


        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter the height of image: ");
            a = Convert.ToInt32(Console.ReadLine());

            int b;
            Console.WriteLine("Enter the width of image: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("The image is in landscape aspect ratio.");
            }
            else if (a < b)
            {
                Console.WriteLine("The image is in portrait aspect ratio.");
            }
            else
            {
                Console.WriteLine("The image is in square aspect ratio.");
            }


            bool isgoldCoustomer = false;

            float price = (isgoldCoustomer) ? 19.95f : 29.95f;

            Console.WriteLine(price);

            int a;
            Console.WriteLine("Enter the speed Limit");
            a = Convert.ToInt32(Console.ReadLine());

            int b;
            Console.WriteLine("Eneter the current Speed");
            b = Convert.ToInt32(Console.ReadLine());

            //total demetait point of that driver


            if (b > a)
            {

                Console.WriteLine("you get an demati point and it i");


            }
            else
            {
                Console.WriteLine("ok");
            }





            int speedlimit;
            Console.WriteLine("Enter the speedLimit ");
            speedlimit = Convert.ToInt32(Console.ReadLine());
            int currentSpeed;
            Console.WriteLine("Enter the currrent speed ");
            currentSpeed = Convert.ToInt32(Console.ReadLine());

            if (currentSpeed <= speedlimit)
            {
                Console.WriteLine("OK");

            }

            else
            {
                int dpoit;
                Console.WriteLine("you excced the limit and and 1 demarit point added\nEndure cureent demarit point");
                dpoit = Convert.ToInt32(Console.ReadLine());

                if (dpoit++ >= 10)
                {
                    Console.WriteLine("your Licenses suspended {0}", dpoit++);
                }
                else
                {
                    Console.WriteLine("your Dpoint is {0}", dpoit++);

                }

            }

            var random = new Random();

            const int passwordLength = 10;

            var buffer = new char[passwordLength];

            for (var i = 0; i < passwordLength; i++)

                buffer[i] = (char)('a' + random.Next(0, 26));







        }
    }
}