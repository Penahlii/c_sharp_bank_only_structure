#nullable disable

using ClassLibrary1.Work;
using ClassLibrary1.Human;

namespace ClassLibrary1;

public class Worker : Person
{
    public string start_time;
    public string end_time;

    List<Operation> operations;

    void Add_Operation(Operation operation) { this.operations.Add(operation); }

    // Constructor

    public Worker(string name, string surname, byte age, string position, float salary, string start_time, string end_time) : base(name, surname, age, position, salary) { }
}