namespace Abs;

public class Car : Vehicle
{
    private bool _airbags;
    private bool _ac;

    public bool Airbags
    {
        get => _airbags;
        set => _airbags = value;
    }

    public bool Ac => _ac;

    public Car(string name, int wheels, string engine, string colour, bool ac, bool airbags) : base(name, wheels, engine, colour)
    {
        _airbags = airbags;
        _ac = ac;
    }
}