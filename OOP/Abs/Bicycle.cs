namespace Abs;

public class Bicycle: Vehicle
{
    private string _gears;


    public string Gears
    {
        get => _gears;
        set => _gears = value;
    }

    public Bicycle(string name, int wheels, string engine, string colour, string gears) : base(name, wheels, engine, colour)
    {
        _gears = gears;
        
        
    }


    public override void Travel()
    {
        base.Travel();
        Console.WriteLine("my legs hurt");
    }
}