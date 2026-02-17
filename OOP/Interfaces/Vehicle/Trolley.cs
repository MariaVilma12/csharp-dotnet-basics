namespace Interfaces;

public class Trolley:Vehicle, ISteerable
{
    public Trolley()
    {
        Name = "Trolley";
        Payment = new Cash();
    }
    
    public void Steer()
    {
        Console.WriteLine("The trolley steers with the dirty bar that my daughter likes to lick.");
    }

    public override void Stop()
    {
        Console.WriteLine("The trolley stops when I stop pushing it.");  
    }
}