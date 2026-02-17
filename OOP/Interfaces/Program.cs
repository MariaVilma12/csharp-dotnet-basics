namespace Interfaces;

class Program
{
    static void Main(string[] args)
    {
        // Vehicle vehicle = new Vehicle();
        // vehicle.Steer();
        // vehicle.Stop();

        List<Vehicle> vehicles = new List<Vehicle>();
        vehicles.Add(new Car());
        vehicles.Add(new Trolley());
        vehicles.Add(new Tram(new Vipps()));
        vehicles.Add(new ElectricCar());
        vehicles.Add(new Trolley());
        

        foreach (Vehicle vehicle in vehicles)
        {
            Console.WriteLine(vehicle.Name);
            
            ISteerable steerable = vehicle as ISteerable;
            steerable?.Steer();
            
            IRefuelable refuelable = vehicle as IRefuelable;
            refuelable?.Refuel();

            vehicle.Stop();

            if (vehicle.Payment.GetType() != typeof(Unpaid))
            {
                vehicle.Payment.Pay();
            }
        }

       
        
    }
}