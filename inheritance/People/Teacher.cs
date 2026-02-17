using Inheritance.School;

namespace Inheritance.People;

public class Teacher:Person
{
    private Subject _subject;
    
    public Teacher(string firstName, string lastName, Subject subject) : base(firstName, lastName)
    {
        this._subject = subject;
    }

    public Subject Subject => _subject;

    public string GetInfoOld()
    {
        return $"{_firstName} {_lastName} teaches {_subject}.";
    }
    
    /// <summary>
    /// teacher info
    /// </summary>
    /// <returns></returns>
    public override string GetInfo()
    {
        return GetInfoOld();
    }
}