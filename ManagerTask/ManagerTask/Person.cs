namespace ManagerTask;

public class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }

    public Person(string name, string surname)
    {
        Name = name;
        Surname = surname;
    }
    public virtual void showInfo()
    {
        Console.WriteLine($"Name => {Name}, Surname => {Surname}");
    }

}
