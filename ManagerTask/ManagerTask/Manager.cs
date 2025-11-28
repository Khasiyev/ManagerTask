using System.Xml.Linq;

namespace ManagerTask;

public class Manager: Person
{
    public Manager(string name, string surname) : base(name, surname)
    {
        Name = name;
        Surname = surname;
    }

}
