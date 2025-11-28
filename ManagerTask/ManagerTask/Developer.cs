namespace ManagerTask;

public class Developer: Person
{
    public Developer(string name, string surname) : base(name, surname)
    {
        Name = name;
        Surname = surname;
    }
    public override void showInfo()
    {
        Console.WriteLine($"Developer Name => {Name}, Surname => {Surname}");
    }
}
