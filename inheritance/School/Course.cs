using System.Collections.Generic;
using System.Text;

namespace Inheritance.School;

public class Course
{
    private string _name;
    private List<Subject> _subjects;

    public string Name => _name;

    public Course(string name)
    {
        _name = name;
        _subjects = new List<Subject>();
    }

    public void AddSubject(Subject subject)
    {
        _subjects.Add(subject);
    }

    private string GetListOfSubjects()
    {
        StringBuilder sb = new StringBuilder();
        foreach (Subject subject in _subjects)
        {
            sb.Append("\t"+subject.Name + "\n");
        }

        return sb.ToString();
    }

    public override string ToString()
    {
        return $" - {_name} - \n\n " + GetListOfSubjects();
    }
}