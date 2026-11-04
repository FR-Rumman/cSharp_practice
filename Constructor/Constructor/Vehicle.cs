namespace Constructor;

class Vehicle
{
    private readonly string _registernumber;
    //public Vehicle()
    //{
    //    Console.WriteLine("Vehicle is initialized");
    //}

    public Vehicle(string registernumber)
    {
        _registernumber = registernumber;
    }
}