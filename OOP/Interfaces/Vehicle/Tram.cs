namespace Interfaces;

public class Tram:Vehicle
{
    public Tram(IPayment payment)
    {
        Name = "Tram";
        Payment = payment;
    }

    public override void Stop()
    {
        Console.WriteLine("The driver stops the tram.");
    }

    
}