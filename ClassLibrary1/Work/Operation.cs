#nullable disable

namespace ClassLibrary1.Work;

public class Operation
{
    public Guid Id { get; set; }

    private string processName;

    public string ProcessName
    {
        get => this.processName;
        set
        {
            if (value.Length >= 3)
                this.processName = value;
            else
                throw new Exception("Invalid Process Name");
        }
    }

    public string Datetime { get; set; }

    // Constructor

    public Operation(string processname)
    {
        this.Id = Guid.NewGuid();
        this.ProcessName = processname;
        this.Datetime = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
    }
}