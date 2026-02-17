namespace Interfaces;

public class Car:Vehicle, ISteerable, IRefuelable
{
    public Car()
    {
        Name = "Car";
    }
    
   

    public override void Stop()
    {
        Console.WriteLine("The car stops when I press the brake.");
    }

    public void Steer()
    {
        Console.WriteLine("The car steers with the steering wheel.");
    }

    public void Refuel()
    {
        Console.WriteLine("The car refuels with gas.");
    }
}