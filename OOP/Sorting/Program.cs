namespace Sorting;

class Program
{
    static void Main(string[] args)
    {
        List<Custom> things = new List<Custom>();
        
        things.Add(new Custom("a", 11));
        things.Add(new Custom("x",7));
        things.Add(new Custom("m", 42));
        things.Add(new Custom("m", 8));
        things.Add(new Custom("m", 4));
        things.Add(new Custom("m", 16));
        things.Add(new Custom("m", 23));

        foreach (Custom custom in things)
        {
            Console.WriteLine(custom);
        }

        Console.WriteLine("--- SORTING ---");
        things.Sort();
        
        foreach (Custom custom in things)
        {
            Console.WriteLine(custom);
        }
    }
}