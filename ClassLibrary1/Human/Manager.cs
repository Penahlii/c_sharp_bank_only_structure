using ClassLibrary1.Interfaces;

namespace ClassLibrary1.Human;

public class Manager : Person, For_All
{
    // ELAVELER
    public void control() => Console.WriteLine("Manager Controlled");
    public void decreasePercentage(float percentage) => Console.WriteLine("Manager Decreased Percentage");
    public void makeMeeting() => Console.WriteLine("Manager Made Meeting");
    public void organize() => Console.WriteLine("Manager Organized");

    // Constructor

    public Manager(string name, string surname, byte age, string position, float salary) : base(name,surname,age,position,salary) { }
}