namespace Constructor;

class Car : Vehicle
{
    public Car(string registationnumber)
     :base(registationnumber)

    {
        Console.WriteLine("Car is initialized {0}", registationnumber);
    }
}