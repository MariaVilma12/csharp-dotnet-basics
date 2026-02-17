namespace Interfaces;

public class ElectricCar: Vehicle, ISteerable,IRefuelable
{
    public ElectricCar()
    {
        Name = " Electric Car";
    }

    public override void Stop()
    {
        Console.WriteLine("The EC stops with its' brakes.");
    }

    public void Steer()
    {
        Console.WriteLine("The EC steers wiht the steering wheel");
    }


    public void Refuel()
    {
        Console.WriteLine("The EC refuels with ELECTRICITY!!!");
    }
}