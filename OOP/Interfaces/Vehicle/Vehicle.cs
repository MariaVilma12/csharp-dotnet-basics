namespace Interfaces;

public abstract class Vehicle
{
    public IPayment Payment = new Unpaid();
    
    public String Name = "vehicle";
    

    public virtual void Stop()
    {
        Console.WriteLine("I dont know how the vehicle stops.");
    }

    public override bool Equals(object? obj)
    {
        return Name == (obj as Vehicle)?.Name;
    }

   
}