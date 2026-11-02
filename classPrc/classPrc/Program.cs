namespace classPrc
{
    class Program
    {
        public class Person2
        {
            public string name;
            public void IndroDuce(string TO)
            {
                Console.WriteLine("hello {0} I am {1}", name, TO);
            }
        }
        static void Main(string[] args)
        {
            var person = new Person2();
            person.name = "Sakib";
            person.IndroDuce("Rumman");
        }
    }
}