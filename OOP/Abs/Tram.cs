namespace Abs;

public class Tram:Vehicle
{
    public Tram(string colour) : base("tram", 16, "electric", colour)
    {
    }

    public sealed override void Travel()
    {
        base.Travel();
    }
}