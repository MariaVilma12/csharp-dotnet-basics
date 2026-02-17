namespace Interfaces;

public class Cash: IPayment
{
    public void Pay()
    {
        Console.WriteLine($"Pay with cash.");
    }
}