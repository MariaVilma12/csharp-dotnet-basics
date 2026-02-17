namespace Encaps;

public class Person
{
    private string _name;
    private string _surname;

    public string Name
    {
        get
        {
            Console.WriteLine("Someone read the name!!!");
            return _name;
        }
        set
        {
            if(value == "craig")
                Console.WriteLine("bad name");
            return;
            _name = value;
            Console.WriteLine($"Name was set to {value}");
        }
    }

    public string Surname
    {
        get { return _surname; }
        set { _surname = value; }
    }
}