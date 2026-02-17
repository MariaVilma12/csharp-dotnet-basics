using System;

namespace Inheritance.People;

public abstract class Person
{
    protected string _firstName;
    protected string _lastName;

    protected string _profession;
    
    /// <summary>
    /// The persons first name.
    /// </summary>
    public string FirstName => _firstName;

    /// <summary>
    /// blaaah
    /// </summary>
    public string LastName => _lastName;

    protected string Profession => _profession;

    /// <summary>
    /// Creates a new person object.
    /// </summary>
    /// <param name="firstName">The person's first name...</param>
    /// <param name="lastName">etc ...</param>
    public Person(string firstName, string lastName)
    {
        this._firstName = firstName;
        this._lastName = lastName;
        this._profession = "person";
    }

    /// <summary>
    /// The person in string format ...
    /// </summary>
    /// <returns></returns>
    public sealed override string ToString()
    {
        return _firstName + " " + _lastName;
    }

    /// <summary>
    /// The persons info 
    /// </summary>
    /// <returns></returns>
    public abstract string GetInfo();
}