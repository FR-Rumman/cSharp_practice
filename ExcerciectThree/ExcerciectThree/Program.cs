namespace ExcerciecThree
{
    class Program
    {
        static void Main()
        {
           var customer = new Customer(1, "rumman");

            var customer1 = new Customer(1);
            customer1.Orders.Add(new(Orders));

            Console.WriteLine(customer.Name);
            Console.WriteLine(customer.Id);

        }
    }
}