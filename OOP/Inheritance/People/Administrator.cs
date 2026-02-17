namespace Inheritance.People;

public class Administrator:Person
{
    public Administrator(string firstName, string lastName) : base(firstName, lastName)
    {
    }
    
    public override string GetInfo()
    {
        return $"{_firstName} is an admin.";
    }
}