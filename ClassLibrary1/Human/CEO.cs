using ClassLibrary1.Interfaces;

namespace ClassLibrary1.Human;

public class CEO : Person, For_All
{
    // ELAVE
    public void control() => Console.WriteLine("CEO Controlled");
    public void decreasePercentage(float percent) => Console.WriteLine("CEO Decreased Percentage");
    public void makeMeeting() => Console.WriteLine("CEO Made Meeting");
    public void organize() => Console.WriteLine("CEO Organized");

    // Constructor

    public CEO(string name, string surname, byte age, string position, float salary) : base(name,surname, age, position, salary) { }
}