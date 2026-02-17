namespace Inheritance.School;

public class Subject
{
    private string _name;

    public string Name => _name;

    public Subject(string name)
    {
        _name = name;
    }

    public void ModifyName(string name)
    {
        _name = name;
    }

    public override string ToString()
    {
        return _name;
    }
}