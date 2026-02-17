namespace Interfaces;

public class Unpaid:IPayment
{
    public void Pay()
    {
        // nothing
        Console.WriteLine("nothing to pay");
    }
}