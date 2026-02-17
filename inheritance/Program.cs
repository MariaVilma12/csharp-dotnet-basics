using System;
using System.Collections.Generic;
using Inheritance.People;
using Inheritance.School;

namespace Inheritance;

class Program
{
    static void Main(string[] args)
    {
        Course bep = new Course("Backend Programming");
        Subject python = new Subject("Python");
        Subject databases = new Subject("Databases");
        Subject csharp = new Subject("C#");
        
        bep.AddSubject(python);
        bep.AddSubject(databases);
        bep.AddSubject(csharp);
        
        Student student = new Student("Craig","Marais", bep);
        Teacher teacher = new Teacher("Bob", "Bobbington", python);
        Administrator admin = new Administrator("Nora", "Solberg");

        List<Person> _people = new List<Person>();
        _people.Add(student);
        _people.Add(teacher);
        _people.Add(admin);

        python.ModifyName("Pie-thon");

        foreach (Person person in _people)
        {
            Student temp_student = person as Student;
            if (temp_student != null)
            {
                Console.WriteLine(temp_student.GetInfoOld());
            }
            
            Teacher temp_teacher = person as Teacher;
            if (temp_teacher != null)
            {
                Console.WriteLine(temp_teacher.GetInfoOld());
            }
            
            // using the abstract GetInfo defined in Person.cs
            Console.WriteLine(person.GetInfo());


        }
        
        
        //Console.WriteLine(bep);
        
        // Console.WriteLine(obj.ToString());
        // //Console.WriteLine(person.ToString());
        // Console.WriteLine(student.ToString());
        // Console.WriteLine(teacher.ToString());

        Console.WriteLine("Press any key to continue ...");
        Console.ReadKey();
    }
}