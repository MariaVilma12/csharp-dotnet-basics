using Inheritance.School;

namespace Inheritance.People;

public class Student:Person
{
    private Course _course;

    public Student(string firstName, string lastName, Course course):base(firstName, lastName)
    {
        this._profession = "student";
        this._course = course;
    }

    public string GetInfoOld()
    {
        return $"{FirstName} is taking the {_course.Name} course. They are a {Profession}.";
    }

    
    public override string GetInfo()
    {
        return GetInfoOld();
    }

    
    public string ToString()
    {
        return base.ToString() + " is the best <3";
    }
}