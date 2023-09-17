#nullable disable

using System.Net.Cache;

namespace ClassLibrary1;

abstract public class Person
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

    public string position { get; set; }

    public float Salary { get; set; }

    // Constructor

    public Person(string name, string surname, byte age, string position, float salary)
    {
        this.Id  = Guid.NewGuid();
        this.Name = name;
        this.Surname = surname;
        this.Age = age;
        this.position = position;
        this.Salary = salary;
    }
}