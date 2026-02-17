namespace AnimalSort;

public class Animal: IComparable
{
    private string species;
    private string name;

    public Animal(string species, string name)
    {
        this.species = species;
        this.name = name;
    }

    public override string ToString()
    {
        return species + " - " + name;
    }

    public int CompareTo(object? obj)
    {
        Animal other = obj as Animal;
        string thisName = this.species + this.name;
        string otherName = other?.species + other?.name;

        return thisName.CompareTo(otherName);
    }
}