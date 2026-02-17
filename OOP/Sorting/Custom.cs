namespace Sorting;

public class Custom: IComparable
{
    private string name;
    private int num;

    public Custom(string name, int num)
    {
        this.name = name;
        this.num = num;
    }

    public override string ToString()
    {
        return name + " " + num;
    }

    public int CompareTo(object? obj)
    {
        Custom other = obj as Custom;
        Console.WriteLine($"Comparing {this} with {other}");

        // comapring with numbers
        return num - other.num;

        //comapring with strings
        //return name.CompareTo(other.name);
    }
}