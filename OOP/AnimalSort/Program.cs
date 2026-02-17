namespace AnimalSort;

class Program
{
    static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>();
        
        
        animals.Add(new Animal("cat", "Floof"));
        animals.Add(new Animal("dog", "Spot"));
        animals.Add(new Animal("fish", "Steve"));
        animals.Add(new Animal("dog", "Muffin"));
        animals.Add(new Animal("cat", "Mr Bigglesworth"));
        animals.Add(new Animal("budgie", "Albert"));
        animals.Add(new Animal("budgie", "Wilfred"));
        
        animals.Sort();

        foreach (Animal animal in animals)
        {
            Console.WriteLine(animal);
        }
    }
}