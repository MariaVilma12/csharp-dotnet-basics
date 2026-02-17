namespace Abs;

class Program
{
    static void Main(string[] args)
    {
        Vehicle v1 = new Bicycle(
            "bike1",
            2, 
            "silver", 
            "my poor legs", 
            "3x6"
        );
        
        Vehicle v2 = new Car(
            "my tesla",
            4, 
            "red", 
            "electric",
            true, 
            false
        );
        
        v1.Travel();
        

        // Vehicle v3 = new Vehicle("hello", 3, "turtle", "yes");
        // v3.Travel();
        Vehicle v4 = new Tram("blue");
        v4.Travel();

        Vehicle v5 = new SuperTram("vantablack");
        v5.Travel();
        
    }
}