#nullable disable

namespace ClassLibrary1.Human;

public class Client
{
    public Guid Id { get; set; }
    private string name;
    public string Name
    {
        get => this.name;
        set
        {
            if (value.Length >= 3)
                this.name = value;
            else
                throw new Exception("Name Length must be at least 3");
        }
    }

    private string surname;
    public string Surname
    {
        get => this.surname;
        set
        {
            if (value.Length >= 3)
                this.surname = value;
            else
                throw new Exception("Surname Length must be at least 3");
        }
    }

    public byte Age { get; set; }
    public string live_adress { get; set; }
    public string work_adress { get; set; }
    private float salary;

    public float Salary
    {
        get => this.salary;
        set
        {
            if (value > 1000)
                this.salary = value;
            else
                throw new Exception("Invalid Salary");
        }
    }


    // Constructor

    public Client(string name, string surname, byte age, string live_adress, string work_adress, float salary)
    {
        this.Id = Guid.NewGuid();
        this.Name = name;
        this.Surname = surname;
        this.Age = age;
        this.live_adress = live_adress;
        this.work_adress = work_adress;
        this.Salary = salary;
    }
}