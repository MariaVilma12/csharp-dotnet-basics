namespace Abs;

public class SuperTram:Tram
{
    public SuperTram(string colour) : base(colour)
    {
        
    }

    public void Travel()
    {
        Console.WriteLine("Took the supertram!!!!");
    }
}