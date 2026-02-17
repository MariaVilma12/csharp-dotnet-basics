namespace Abs;

public abstract class Vehicle
{
    protected int _wheels;
    protected string _engine;
    protected string _colour;
    protected string _name;

    public int Wheels
    {
        get => _wheels;
    }

    public string Engine
    {
        get => _engine;
    }

    public string Colour
    {
        get => _colour;
    }

    public string Name => _name;

    public Vehicle(string name, int wheels, string engine, string colour)
    {
        _name = name;
        _wheels = wheels;
        _engine = engine;
        _colour = colour;
    }
    

    public virtual void Travel()
    {
        Console.WriteLine("travelled using " + _name);
    }
}