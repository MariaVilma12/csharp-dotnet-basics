namespace ParallelArrays;

class Program
{
    
    static void Main(string[] args)
    {
        String[] Titles = new String[]
        {
            "Lord of the Flies",
            "The Hitchhiker's Guide to the Galaxy",
            "Ready Player One",
            "Foundation"
        };

        String[] Authors = new String[]
        {
            "William Golding",
            "Douglas Adams",
            "Ernest Cline",
            "Isaac Asimov"
        };
        
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(Titles[i] + " was written by " + Authors[i]);
        }
    }
}